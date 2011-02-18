package JavaPerformance;

import java.util.ArrayList;

public abstract class SomeTestRunner
{
	protected ArrayList<SomeTest> _tests = new ArrayList<SomeTest>();
	private long _maxTotalMemory = 0;
    
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
            _maxTotalMemory = Math.max(Runtime.getRuntime().totalMemory() - Runtime.getRuntime().freeMemory(), _maxTotalMemory);
        }
    }

    public void WriteResult()
    {
    	System.out.println();
    	System.out.println(this.getName() + ":");
    	for (int i = 0; i < _tests.size(); ++i)
        {
            SomeTest test = _tests.get(i);        	
        	System.out.println(String.format("%.5f_op/mks_%.2f_ms._%.0e_%s", test.getScore(), test.getTime(), (float)test.getIterationCount(), test.getName()));
        }
    }
    
	public long GetMaxTotalMemory()
	{
		return _maxTotalMemory;
	}
}