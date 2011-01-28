package JavaPerformance.MathTests;

import JavaPerformance.SomeTestRunner;

public class MathTestsRunner extends SomeTestRunner
{
	@Override
	protected void InitTests() 
	{
        _name = "Математические";

        _tests.add(new Div10Test());
        _tests.add(new SqrtTest());
        _tests.add(new SinTest());
        _tests.add(new CosTest());
        _tests.add(new TanTest());
        _tests.add(new Log10Test());
        _tests.add(new ExpTest());
        _tests.add(new AsinTest());
        _tests.add(new AcosTest());
        _tests.add(new AtanTest());		
	}
}
