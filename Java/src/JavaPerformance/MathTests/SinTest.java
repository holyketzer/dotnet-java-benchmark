package JavaPerformance.MathTests;

import JavaPerformance.SomeTest;

public class SinTest extends SomeTest 
{
    public SinTest()
    {
        _name = "Синус";
        _iterationCount = MathTestParams.iterationCount;
    }
    
	@Override
	public void Do() 
	{
        StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            @SuppressWarnings("unused")
			double x = Math.sin(i);
        }
        StopTiming();
	}
}
