package JavaPerformance.StringConversionsTests;

import JavaPerformance.SomeTest;

public class IntParseTest extends SomeTest 
{
	public IntParseTest()
    {
        _name = "Парсинг int";
        _iterationCount = StringConversionsTestParams.iterationCount/10;
    }
	
	@Override
	public void Do() 
	{
		String[] arr = new String[_iterationCount];

        for (int i = 0; i < arr.length; ++i)
        {
            arr[i] = Integer.toString(i);
        }

        StartTiming();
        for (int i = 0; i < arr.length; ++i)
        {
            @SuppressWarnings("unused")
			int x = Integer.parseInt(arr[i]);
        }
        StopTiming();
	}
}
