package JavaPerformance.MathTests;

import JavaPerformance.SomeTest;

public class AcosTest extends SomeTest 
{
    public AcosTest()
    {
        _name = "Арккосинус";
        _iterationCount = MathTestParams.iterationCount;
    }
    
	@Override
	public void Do() 
	{
        StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            @SuppressWarnings("unused")
			double x = Math.acos(i);
        }
        StopTiming();
	}
}
