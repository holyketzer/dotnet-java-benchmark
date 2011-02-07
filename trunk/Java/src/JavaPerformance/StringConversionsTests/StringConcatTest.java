package JavaPerformance.StringConversionsTests;

import JavaPerformance.SomeTest;

public class StringConcatTest extends SomeTest 
{
    public StringConcatTest()
    {
        _name = "Конкатенация строк";
        _iterationCount = StringConversionsTestParams.iterationCount / 500;
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
        String s = "";
        for (int i = 0; i < arr.length; ++i)
        {
            s += arr[i];
        }
        StopTiming();
	}

}
