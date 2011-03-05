package JavaPerformance.MathTests;

import JavaPerformance.SomeTest;

public class CosTest extends SomeTest 
{
    public CosTest()
    {
        _name = "Косинус";
        _iterationCount = MathTestParams.iterationCount*5;
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
			double x = Math. cos(val);
            val += dt;
        }
        StopTiming();
	}
}
