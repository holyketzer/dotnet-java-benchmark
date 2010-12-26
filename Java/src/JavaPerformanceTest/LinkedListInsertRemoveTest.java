package JavaPerformanceTest;

import java.util.LinkedList;

public class LinkedListInsertRemoveTest extends SomeTest
{
    public LinkedListInsertRemoveTest()
    {
        _name = "��������� ������<int> �������/�������� ���������";
    }
    
    @Override
    public void Do()
    {            
        LinkedList<Integer> list = new LinkedList<Integer>();
        StartTiming();
        for (int i = 0; i < ListTestParams.ListInsertRemoveSize; ++i)
        {
            list.addLast(i);
        }
        while (list.size() > 0)
        {
            list.removeLast();
        }
        StopTiming();
    }
}
