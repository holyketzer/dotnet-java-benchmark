package JavaPerformance.MathTests;

import JavaPerformance.SomeTest;

public class AsinTest extends SomeTest 
{
    public AsinTest()
    {
        _name = "��������";
        _iterationCount = MathTestParams.iterationCount;
    }
    
	@Override
	public void Do() 
	{
        StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            @SuppressWarnings("unused")
			double x = Math.asin(i);
        }
        StopTiming();
	}
}
