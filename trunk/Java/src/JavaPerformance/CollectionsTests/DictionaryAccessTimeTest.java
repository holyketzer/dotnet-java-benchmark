package JavaPerformance.CollectionsTests;

import java.util.Hashtable;

import JavaPerformance.SomeTest;

public class DictionaryAccessTimeTest extends SomeTest 
{
    public DictionaryAccessTimeTest()
    {
        _name = "Dictionary<int, string> последовательный доступ к элементам";
        _iterationCount = CollectionTestParams.ListAccessSize;
    }
    
	@Override
	public void Do() 
	{
		Hashtable<Integer, String> dic = new Hashtable<Integer, String>();
        
        try
        {
            for (int i = 0; i < _iterationCount; ++i)
            {
                dic.put(i, Integer.toString(i));
            }
        }
        catch (OutOfMemoryError e)
        {
            System.out.println("!! Ќедостаточно пам€ти дл€ полного теста");
            _iterationCount = dic.size();
        }

        StartTiming();
        for (int i = 0; i < dic.size(); ++i)
        {
            @SuppressWarnings("unused")
			String x = dic.get(i);
        }
        StopTiming();
	}
}
