package JavaPerformance.StringConversionsTests;

import JavaPerformance.SomeTest;

public class DoubleParseTest extends SomeTest 
{
    public DoubleParseTest()
    {
        _name = "Парсинг double";
        _iterationCount = StringConversionsTestParams.iterationCount/2;
    }
    
	@Override
	public void Do() 
	{
        String[] arr = new String[_iterationCount];

        for (int i = 0; i < arr.length; ++i)
        {
            double x = i;
            x = x / 123 + i;
            arr[i] = Double.toString(x);
        }

        StartTiming();
        for (int i = 0; i < arr.length; ++i)
        {
            @SuppressWarnings("unused")
			double x = Double.parseDouble(arr[i]);
        }
        StopTiming();
	}
}
