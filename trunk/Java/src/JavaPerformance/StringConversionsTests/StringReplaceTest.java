package JavaPerformance.StringConversionsTests;

import JavaPerformance.SomeTest;

public class StringReplaceTest extends SomeTest 
{
    public StringReplaceTest()
    {
        _name = "Замена символов в string";
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
        String s = sb.toString();

        StartTiming();
        for (int i = 0; i < 10; ++i)
        {
            s = s.replace(Integer.toString(i), "+");
        }
        StopTiming();
	}
}
