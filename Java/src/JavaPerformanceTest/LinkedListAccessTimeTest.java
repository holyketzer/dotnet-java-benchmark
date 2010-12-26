package JavaPerformanceTest;

import java.util.Iterator;
import java.util.LinkedList;

public class LinkedListAccessTimeTest extends SomeTest
{
    public LinkedListAccessTimeTest()
    {
        _name = "Связанный список<int> последовательный доступ к элементам";
    }

    @Override
    public void Do()
    {
        LinkedList<Integer> list = new LinkedList<Integer>();

        for (int i = 0; i < ListTestParams.ListAccessSize; ++i)
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
    }
}