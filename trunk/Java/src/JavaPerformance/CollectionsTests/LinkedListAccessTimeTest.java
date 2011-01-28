package JavaPerformance.CollectionsTests;

import java.util.Iterator;
import java.util.LinkedList;

import JavaPerformance.SomeTest;

public class LinkedListAccessTimeTest extends SomeTest
{
    public LinkedListAccessTimeTest()
    {
        _name = "LinkedList<int> последовательный доступ к элементам";
        _iterationCount = CollectionTestParams.ListAccessSize;
    }

    @Override
    public void Do()
    {
        LinkedList<Integer> list = new LinkedList<Integer>();

        for (int i = 0; i < _iterationCount; ++i)
        {
            list.addLast(i);
        }

        StartTiming();
        for (int i = 0; i < 100; ++i)
        {
            Iterator<Integer> iter = list.iterator();
        	while (iter.hasNext())
            {
                @SuppressWarnings("unused")
				int x = iter.next();
            }
        }
        StopTiming();
        
        list.clear();
    }
}