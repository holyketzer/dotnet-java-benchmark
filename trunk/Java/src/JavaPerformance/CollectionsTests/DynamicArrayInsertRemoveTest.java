package JavaPerformance.CollectionsTests;

import java.util.ArrayList;

import JavaPerformance.SomeTest;

public class DynamicArrayInsertRemoveTest extends SomeTest
{
    public DynamicArrayInsertRemoveTest()
    {
        _name = "DynamicArray<int> вставка и удаление элементов";
        _iterationCount = CollectionTestParams.ListInsertRemoveSize / 4;
    }
    
    @Override
    public void Do()
    {            
        ArrayList<Integer> list = new ArrayList<Integer>();
        StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            list.add(i);
        }
        while (list.size() > 0)
        {
            list.remove(0);
        }
        StopTiming();
        
        list.clear();
    }
}
