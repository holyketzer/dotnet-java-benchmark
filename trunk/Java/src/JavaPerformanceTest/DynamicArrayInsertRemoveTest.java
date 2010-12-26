package JavaPerformanceTest;

import java.util.ArrayList;

public class DynamicArrayInsertRemoveTest extends SomeTest
{
    public DynamicArrayInsertRemoveTest()
    {
        _name = "Динамический массив<int> вставка/удаление элементов";
    }
    
    @Override
    public void Do()
    {            
        ArrayList<Integer> list = new ArrayList<Integer>();
        StartTiming();
        for (int i = 0; i < ListTestParams.ListInsertRemoveSize; ++i)
        {
            list.add(i);
        }
        while (list.size() > 0)
        {
            list.remove(0);
        }
        StopTiming();
    }
}
