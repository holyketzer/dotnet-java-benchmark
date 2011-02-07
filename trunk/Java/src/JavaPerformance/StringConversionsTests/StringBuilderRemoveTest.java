package JavaPerformance.StringConversionsTests;

import JavaPerformance.SomeTest;

public class StringBuilderRemoveTest extends SomeTest 
{
    public StringBuilderRemoveTest()
    {
        _name = "Удаление символов из StringBuilder";
        _iterationCount = StringConversionsTestParams.iterationCount / 10;
    }
    
	@Override
	public void Do() 
	{
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < _iterationCount; ++i)
        {
            sb.append(Integer.toString(i));
        }

        StartTiming();
        while (sb.length() > 0)
        {
            sb.deleteCharAt(sb.length() - 1);
        }
        StopTiming();
	}
}
