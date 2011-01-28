package JavaPerformance.ArraysTests;

import JavaPerformance.SomeTest;

public class ArrayDoubleCreateTest extends SomeTest 
{
	public ArrayDoubleCreateTest()
	{
	    _name = "double[] создание и заполнение массива";
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
				StartTiming();
				array = new double[_iterationCount];
			}
			catch (OutOfMemoryError e) 
			{
				_iterationCount /= 2;
				System.out.println("!! Недостаточно памяти для полного теста");
			}
		}	
		
        for (int i = 0; i < array.length; ++i)
        {
            array[i] = i;
        }
        StopTiming();
	}

}
