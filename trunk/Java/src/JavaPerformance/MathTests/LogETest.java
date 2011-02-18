package JavaPerformance.MathTests;

import JavaPerformance.SomeTest;

public class LogETest extends SomeTest 
{
	public LogETest()
    {
        _name = "Натуральный логарифм";
        _iterationCount = MathTestParams.iterationCount;
    }

	@Override
    public void Do()
    {
        StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            @SuppressWarnings("unused")
			double x = Math.log(i);
        }
        StopTiming();
    }

}
