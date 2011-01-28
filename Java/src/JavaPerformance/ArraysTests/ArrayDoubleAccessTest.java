package JavaPerformance.ArraysTests;

import JavaPerformance.SomeTest;

public class ArrayDoubleAccessTest extends SomeTest 
{
	public ArrayDoubleAccessTest()
    {
        _name = "double[] последовательный доступ к элементам";
        _iterationCount = ArrayTestParams.arraySize;
    }
	
	@Override
	public void Do() 
	{
		double[] array = null;
		while (array == null)
		{
			try
			{
				array = new double[_iterationCount];
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
			double x = array[i];
        }
        for (int i = array.length - 1; i > 0; --i)
        {
            @SuppressWarnings("unused")
			double x = array[i];
        }
        StopTiming();    
	}
}
