package JavaPerformance.MathTests;

import JavaPerformance.SomeTest;

public class AtanTest extends SomeTest 
{
    public AtanTest()
    {
        _name = "Арктангенс";
        _iterationCount = MathTestParams.iterationCount;
    }
    
	@Override
	public void Do() 
	{
        StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            @SuppressWarnings("unused")
			double x = Math.atan(i);
        }
        StopTiming();
	}
}
