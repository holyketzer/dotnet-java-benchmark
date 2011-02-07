package JavaPerformance.StringConversionsTests;

import JavaPerformance.SomeTest;

public class StringBuilderConcatTest extends SomeTest 
{
    public StringBuilderConcatTest()
    {
        _name = "Конкатенация строк в StringBuilder";
        _iterationCount = StringConversionsTestParams.iterationCount/2;
    }
    
	@Override
	public void Do() 
	{
        String[] arr = new String[_iterationCount];

        for (int i = 0; i < arr.length; ++i)
        {
            arr[i] = Integer.toString(i);
        }

        StartTiming();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < arr.length; ++i)
        {
            sb.append(arr[i]);
        }
        @SuppressWarnings("unused")
		String s = sb.toString();
        StopTiming();
	}
}
