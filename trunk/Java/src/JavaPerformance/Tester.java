package JavaPerformance;

import java.util.ArrayList;
import java.util.Iterator;

import JavaPerformance.ArraysTests.ArraysTestsRunner;
import JavaPerformance.CollectionsTests.CollectionsTestsRunner;
import JavaPerformance.MathTests.MathTestsRunner;
import JavaPerformance.RandomTests.RandomTestsRunner;
import JavaPerformance.StringConversionsTests.StringConversionsTestRunner;

public class Tester 
{
	private ArrayList<SomeTestRunner> _testsRunners = new ArrayList<SomeTestRunner>();  
    private int _totalLoops = 1;
    
    public Tester()
    {
    	InitTestsRunners();
    }
    
    public Tester(int totalLoops)
    {
    	_totalLoops = totalLoops;
    	InitTestsRunners();
    }
    
    private void InitTestsRunners()
    {
    	_testsRunners.add(new MathTestsRunner());
    	_testsRunners.add(new RandomTestsRunner());
    	_testsRunners.add(new ArraysTestsRunner());
    	_testsRunners.add(new CollectionsTestsRunner());
    	_testsRunners.add(new StringConversionsTestRunner());
    }
    
    public void Do()
    {        
    	System.out.println("total loops = " + _totalLoops);
    	for (int i = 0; i < _totalLoops; ++i)
    	{
    		System.out.println();
    		System.out.println("loop #" + (i+1));
    		
    		for (Iterator<SomeTestRunner> iterator = _testsRunners.iterator(); iterator.hasNext();)
	        {	    		
	    		iterator.next().Do();
	        }
    	}
    }

    public void WriteResult()
    {
    	for (Iterator<SomeTestRunner> iterator = _testsRunners.iterator(); iterator.hasNext();)
    	{
        	iterator.next().WriteResult();
        }
    }
}
