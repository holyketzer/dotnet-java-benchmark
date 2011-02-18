package JavaPerformance.MathTests;

import JavaPerformance.SomeTest;

public class SinTest extends SomeTest 
{
    public SinTest()
    {
        _name = "Синус";
        _iterationCount = MathTestParams.iterationCount*5;
    }
    
	@Override
	public void Do() 
	{
        double val = 0;
        double dt = 1;
        dt /= _iterationCount;
        
        StartTiming();        
        for (int i = 0; i < _iterationCount; ++i)
        {
            @SuppressWarnings("unused")
			double x = Math.sin(val);
            val += dt;
        }
        StopTiming();
	}
}
