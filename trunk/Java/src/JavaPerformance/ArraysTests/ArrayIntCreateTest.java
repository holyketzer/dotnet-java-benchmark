package JavaPerformance.ArraysTests;

import JavaPerformance.SomeTest;

public class ArrayIntCreateTest extends SomeTest 
{
	public ArrayIntCreateTest()
    {
		_name = "int[] �������� � ���������� �������";
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
				StartTiming();
				array = new int[_iterationCount];
			}
			catch (OutOfMemoryError e) 
			{
				_iterationCount /= 2;
				System.out.println("!! ������������ ������ ��� ������� �����");
			}
		}		
		
		for (int i = 0; i < array.length; ++i)
		{
		    array[i] = i;
		}
		StopTiming();
	}
}
