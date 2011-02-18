package JavaPerformance.StringConversionsTests;

import JavaPerformance.SomeTest;

public class DoubleToStringTest extends SomeTest 
{
    public DoubleToStringTest()
    {
        _name = "double.ToString()";
        _iterationCount = StringConversionsTestParams.iterationCount/10;
    }
    
	@Override
	public void Do() 
	{
        double[] arr = new double[_iterationCount];

        for (int i = 0; i < arr.length; ++i)
        {
            double x = i;
            arr[i] = x / 123 + i;
        }

        StartTiming();
        for (int i = 0; i < arr.length; ++i)
        {
            @SuppressWarnings("unused")
			String s = Double.toString(arr[i]);
        }
        StopTiming(); 
	}
}
