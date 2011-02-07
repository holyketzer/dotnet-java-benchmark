package JavaPerformance.CollectionsTests;

import java.util.Hashtable;

import JavaPerformance.SomeTest;

public class DictionaryInsertRemoveTest extends SomeTest 
{
    public DictionaryInsertRemoveTest()
    {
        _name = "Dictionary<int, string> вставка и удаление элементов";
        _iterationCount = CollectionTestParams.ListInsertRemoveSize * 2;
    }
    
	@Override
	public void Do() 
	{
		Hashtable<Integer, String> dic = new Hashtable<Integer, String>();

        StartTiming();
        try
        {
            for (int i = 0; i < _iterationCount; ++i)
            {
                dic.put(i, Integer.toString(i));
            }
        }
        catch (OutOfMemoryError e)
        {
            System.out.println("!! Недостаточно памяти для полного теста");
            _iterationCount = dic.size();
        }

        while (dic.size() > 0)
        {
            dic.remove(dic.size() - 1);
        }
        StopTiming();	
	}
}
