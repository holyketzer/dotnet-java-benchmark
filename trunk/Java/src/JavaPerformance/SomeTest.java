package JavaPerformance;

public abstract class SomeTest
{
    public abstract void Do();
    
    public void Reset()
    {
    	_totalTime = 0;
    	_count = 0;
    }

    protected String _name = "";
    public String getName()
    {
        return _name;
    }

    protected long _totalTime = 0;
    public float getTime()
    {
        if (_count == 0)
        {
        	return 0;
        }
        else
        {
        	return _totalTime / _count;
        }
    }
    
    protected int _iterationCount = 1;
    public float getScore()
    {
        float time = this.getTime();
        if (_iterationCount == 0 || time == 0)
        {
            return 0;
        }
        else
        {
            return _iterationCount / (1000 * time);
        }
    }       
    
    public int getIterationCount()
    {
    	return _iterationCount;
    }
    
    protected long _lastStartTime = 0;
    protected int _count = 0;

    protected void StartTiming()
    {
    	_lastStartTime = System.currentTimeMillis();
    }

    protected void StopTiming()
    {
        _totalTime += System.currentTimeMillis() - _lastStartTime;
        ++_count;
    }
}