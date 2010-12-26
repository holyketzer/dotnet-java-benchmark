package JavaPerformanceTest;

import java.util.ArrayList;

public class DynamicArrayAccessTimeTest extends SomeTest
{
    public DynamicArrayAccessTimeTest()
    {
        _name = "Динамический массив<int> последовательный доступ к элементам";
    }
    
    @Override
    public  void Do()
    {
        ArrayList<Integer> list = new ArrayList<Integer>();
        
        for (int i = 0; i < ListTestParams.ListAccessSize; ++i)
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
    }
}