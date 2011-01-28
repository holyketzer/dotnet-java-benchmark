package JavaPerformance.MathTests;

import JavaPerformance.SomeTest;

public class CosTest extends SomeTest 
{
    public CosTest()
    {
        _name = "Косинус";
        _iterationCount = MathTestParams.iterationCount;
    }
    
	@Override
	public void Do() 
	{
        StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            @SuppressWarnings("unused")
			double x = Math.cos(i);
        }
        StopTiming();
	}
}
