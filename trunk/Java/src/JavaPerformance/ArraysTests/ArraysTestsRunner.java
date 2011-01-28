package JavaPerformance.ArraysTests;

import JavaPerformance.SomeTestRunner;

public class ArraysTestsRunner extends SomeTestRunner 
{
	@Override
	protected void InitTests() 
	{
		 _name = "Массивы";

         _tests.add(new ArrayIntCreateTest());
         _tests.add(new ArrayIntAccessTest());
         _tests.add(new ArrayDoubleCreateTest());
         _tests.add(new ArrayDoubleAccessTest());
	}
}
