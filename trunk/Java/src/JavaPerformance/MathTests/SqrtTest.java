package JavaPerformance.MathTests;

import JavaPerformance.SomeTest;

public class SqrtTest extends SomeTest 
{
    public SqrtTest()
    {
        _name = " вадратный корень";
        _iterationCount = MathTestParams.iterationCount * 10;
    }
    
	@Override
	public void Do() 
	{
        StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            @SuppressWarnings("unused")
			double x = Math.sqrt(i);
        }
        StopTiming();
	}
}
