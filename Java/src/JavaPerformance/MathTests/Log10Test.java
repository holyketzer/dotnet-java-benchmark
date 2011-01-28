package JavaPerformance.MathTests;

import JavaPerformance.SomeTest;

public class Log10Test extends SomeTest 
{
    public Log10Test()
    {
        _name = "Десятичный логарифм";
        _iterationCount = MathTestParams.iterationCount * 10;
    }
    
	@Override
	public void Do() 
	{
        StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            @SuppressWarnings("unused")
			double x = Math.log10(i);
        }
        StopTiming();
	}
}
