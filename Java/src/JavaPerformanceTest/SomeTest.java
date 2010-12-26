package JavaPerformanceTest;

public abstract class SomeTest
{
    public abstract void Do();

    protected String _name = "";
    public String getName()
    {
        return _name;
    }

    protected long _time = 0;
    public long getTime()
    {
        return _time;
    }

    protected void StartTiming()
    {
        _time = System.currentTimeMillis();
    }

    protected void StopTiming()
    {
        _time = System.currentTimeMillis() - _time;
    }
}