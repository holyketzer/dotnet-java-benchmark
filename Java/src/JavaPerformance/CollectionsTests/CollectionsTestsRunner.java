package JavaPerformance.CollectionsTests;

import JavaPerformance.CollectionsTests.DynamicArrayAccessTimeTest;
import JavaPerformance.CollectionsTests.DynamicArrayInsertRemoveTest;
import JavaPerformance.CollectionsTests.LinkedListAccessTimeTest;
import JavaPerformance.CollectionsTests.LinkedListInsertRemoveTest;
import JavaPerformance.SomeTestRunner;

public class CollectionsTestsRunner extends SomeTestRunner 
{
	@Override
	protected void InitTests() 
	{
		_name = "Коллекции";

        _tests.add(new DynamicArrayAccessTimeTest());
        _tests.add(new DynamicArrayInsertRemoveTest());
        _tests.add(new LinkedListAccessTimeTest());
        _tests.add(new LinkedListInsertRemoveTest());
        _tests.add(new StackInsertRemoveTest());
        _tests.add(new QueueInsertRemoveTest());
	}

}
