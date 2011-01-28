package JavaPerformance.RandomTests;

import JavaPerformance.RandomTests.DoubleRandomTest;
import JavaPerformance.RandomTests.IntRandomTest;
import JavaPerformance.SomeTestRunner;

public class RandomTestsRunner extends SomeTestRunner 
{
	@Override	
	protected void InitTests() 
	{
        _name = "Генерация случайных чисел";
		
		_tests.add(new IntRandomTest());
        _tests.add(new DoubleRandomTest());		
	}
}
