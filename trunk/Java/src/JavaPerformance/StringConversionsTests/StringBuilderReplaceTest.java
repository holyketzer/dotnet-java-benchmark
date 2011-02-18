package JavaPerformance.StringConversionsTests;

import JavaPerformance.SomeTest;

public class StringBuilderReplaceTest extends SomeTest 
{
    public StringBuilderReplaceTest()
    {
        _name = "������ �������� � StringBuilder";
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
        for (int i = 0; i < 10; ++i)
        {
        	String str = Integer.toString(i);
        	char c = str.charAt(0);

        	for (int pos = 0; pos < sb.length(); ++pos)
        	{
        		if (sb.charAt(pos) == c)
        		{
        			sb.replace(pos, pos+1, "+");
        		}
        	}
        }
        StopTiming();
	}
}
