package JavaPerformance.ArraysTests;

import JavaPerformance.SomeTest;

public class ArrayIntAccessTest extends SomeTest 
{
	public ArrayIntAccessTest()
    {
        _name = "int[] последовательный доступ к элементам";
        _iterationCount = ArrayTestParams.arraySize;
    }
	
	@Override
	public void Do() 
	{
		int[] array = null;
		while (array == null)
		{
			try
			{
				array = new int[_iterationCount];
			}
			catch (OutOfMemoryError e) 
			{
				_iterationCount /= 2;
				System.out.println("!! Ќедостаточно пам€ти дл€ полного теста");
			}
		}		
		
        for (int i = 0; i < array.length; ++i)
        {
            array[i] = i;
        }

        StartTiming();
        for (int i = 0; i < array.length; ++i)
        {
            @SuppressWarnings("unused")
			int x = array[i];
        }
        for (int i = array.length - 1; i > 0; --i)
        {
            @SuppressWarnings("unused")
			int x = array[i];
        }
        StopTiming();
	}
}
