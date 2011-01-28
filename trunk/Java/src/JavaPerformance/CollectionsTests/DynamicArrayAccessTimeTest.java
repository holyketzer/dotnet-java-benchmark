package JavaPerformance.CollectionsTests;

import java.util.ArrayList;

import JavaPerformance.SomeTest;

public class DynamicArrayAccessTimeTest extends SomeTest
{
    public DynamicArrayAccessTimeTest()
    {
        _name = "DynamicArray<int> последовательный доступ к элементам";
        _iterationCount = CollectionTestParams.ListAccessSize;
    }
    
    @Override
    public  void Do()
    {
        ArrayList<Integer> list = new ArrayList<Integer>();
        
        for (int i = 0; i < _iterationCount; ++i)
        {
            list.add(i);
        }

        StartTiming();
        for (int i = 0; i < 100; ++i)
        {
            for (int j = 0; j < list.size(); ++j)
            {
                @SuppressWarnings("unused")
				int x = list.get(j);
            }
        }
        StopTiming();            
        
        list.clear();
    }
}