package JavaPerformance.StringConversionsTests;

import JavaPerformance.SomeTest;

public class IntToStringTest extends SomeTest 
{
    public IntToStringTest()
    {
        _name = "int.ToString()";
        _iterationCount = StringConversionsTestParams.iterationCount;
    }
    
	@Override
	public void Do() 
	{
        StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            @SuppressWarnings("unused")
			String s = Integer.toString(i);
        }
        StopTiming();    
    }
}
