package JavaPerformance.MathTests;

import JavaPerformance.SomeTest;

public class TanTest extends SomeTest 
{
    public TanTest()
    {
        _name = "Тангенс";
        _iterationCount = MathTestParams.iterationCount;
    }
    
	@Override
	public void Do() 
	{
		double val = 0;
        double dt = Math.PI * 2;
        dt /= _iterationCount;
        
        StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            @SuppressWarnings("unused")
			double x = Math.tan(val);
            val += dt;
        }
        StopTiming();
	}
}
