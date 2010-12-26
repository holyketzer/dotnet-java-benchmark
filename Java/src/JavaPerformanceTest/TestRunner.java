package JavaPerformanceTest;

import java.util.ArrayList;

public class TestRunner
{
    private ArrayList<SomeTest> _tests = new ArrayList<SomeTest>();
    
    public TestRunner()
    {
        _tests.add(new IntRandomTest());
        _tests.add(new DoubleRandomTest());
        _tests.add(new DynamicArrayAccessTimeTest());
        _tests.add(new DynamicArrayInsertRemoveTest());
        _tests.add(new LinkedListAccessTimeTest());
        _tests.add(new LinkedListInsertRemoveTest());
    }
    
    public void Do()
    {        
        for (int i = 0; i < _tests.size(); ++i)
        {
            SomeTest test = _tests.get(i);
        	System.out.println("running test: " + test.getName());
            test.Do();
        }
    }

    public void WriteResult()
    {
    	System.out.println();
    	for (int i = 0; i < _tests.size(); ++i)
        {
            SomeTest test = _tests.get(i);
        	System.out.println(test.getTime() + "\t ms. " + test.getName());
        }
    }
}