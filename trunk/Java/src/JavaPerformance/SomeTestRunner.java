package JavaPerformance;

import java.util.ArrayList;

public abstract class SomeTestRunner
{
	protected ArrayList<SomeTest> _tests = new ArrayList<SomeTest>();
    
    public SomeTestRunner()
    {
    	InitTests();
    }
    
    protected abstract void InitTests();    
    
    protected String _name = "";
    public String getName()
    {
    	return _name;
    }   
       
    public void Do()
    {        
    	System.out.println();
    	System.out.println("running testgroup: " + this.getName());
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
    	System.out.println(this.getName() + ":");
    	for (int i = 0; i < _tests.size(); ++i)
        {
            SomeTest test = _tests.get(i);        	
        	System.out.println(String.format("%.5f op/mks %.2f ms. %.0e %s", test.getScore(), test.getTime(), (float)test.getIterationCount(), test.getName()));
        }
    }
}