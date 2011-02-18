package JavaPerformance.StringConversionsTests;

import JavaPerformance.SomeTest;

public class FloatToStringTest extends SomeTest 
{
    public FloatToStringTest()
    {
        _name = "float.ToString()";
        _iterationCount = StringConversionsTestParams.iterationCount/10;
    }
    
	@Override
	public void Do() 
	{
        float[] arr = new float[_iterationCount];

        for (int i = 0; i < arr.length; ++i)
        {
            float x = i;
            arr[i] = x / 123 + i;
        }

        StartTiming();
        for (int i = 0; i < arr.length; ++i)
        {
            @SuppressWarnings("unused")
			String s =  Float.toString(arr[i]);
        }
        StopTiming();
	}
}
