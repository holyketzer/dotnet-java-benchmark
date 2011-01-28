package JavaPerformance.MathTests;

import JavaPerformance.SomeTest;

public class Div10Test extends SomeTest 
{
	public Div10Test()
	{
		_name = "Деление целых чисел на 10";
		_iterationCount = MathTestParams.iterationCount * 10;
	}
	 
	@Override
	public void Do() 
	{
		StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            @SuppressWarnings("unused")
			int x = i / 10;
        }
        StopTiming();
	}
}
