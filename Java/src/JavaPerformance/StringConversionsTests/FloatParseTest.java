package JavaPerformance.StringConversionsTests;

import JavaPerformance.SomeTest;

public class FloatParseTest extends SomeTest 
{
	public FloatParseTest()
	{
	    _name = "Парсинг float";
	    _iterationCount = StringConversionsTestParams.iterationCount/2;
	}
	 
	@Override
	public void Do() 
	{
		String[] arr = new String[_iterationCount];

        for (int i = 0; i < arr.length; ++i)
        {
            float x = i;
            x = x / 123 + i;
            arr[i] = Float.toHexString(x);
        }

        StartTiming();
        for (int i = 0; i < arr.length; ++i)
        {
            @SuppressWarnings("unused")
			float x = Float.parseFloat(arr[i]);
        }
        StopTiming();
	}

}
