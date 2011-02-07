package JavaPerformance.StringConversionsTests;

import JavaPerformance.SomeTest;

public class StringRemoveTest extends SomeTest 
{
    public StringRemoveTest()
    {
        _name = "Удаление символов из строк";
        _iterationCount = StringConversionsTestParams.iterationCount / 1000;
    }
    
	@Override
	public void Do() 
	{
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < _iterationCount; ++i)
        {
            sb.append(Integer.toString(i));
        }
        String s = sb.toString();

        StartTiming();
        
        while (s.length() > 0)
        {
            s = s.substring(0, s.length() - 1);
        }
        StopTiming();
	}
}
