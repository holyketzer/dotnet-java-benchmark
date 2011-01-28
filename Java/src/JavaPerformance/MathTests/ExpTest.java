package JavaPerformance.MathTests;

import JavaPerformance.SomeTest;

public class ExpTest extends SomeTest 
{
    public ExpTest()
    {
        _name = "Ёкспонента";
        _iterationCount = MathTestParams.iterationCount;
    }
    
	@Override
	public void Do() 
	{
        StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            @SuppressWarnings("unused")
			double x = Math.exp(i);
        }
        StopTiming();
	}
}
