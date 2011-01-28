package JavaPerformance.CollectionsTests;

import java.util.LinkedList;

import JavaPerformance.SomeTest;

public class LinkedListInsertRemoveTest extends SomeTest
{
    public LinkedListInsertRemoveTest()
    {
        _name = "LinkedList<int> вставка и удаление элементов";
        _iterationCount = CollectionTestParams.ListInsertRemoveSize * 10;
    }
    
    @Override
    public void Do()
    {            
        LinkedList<Integer> list = new LinkedList<Integer>();
        StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            list.addLast(i);
        }
        while (list.size() > 0)
        {
            list.removeLast();
        }
        StopTiming();
        
        list.clear();
    }
}
