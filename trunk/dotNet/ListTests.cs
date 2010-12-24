using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPerformanceTest
{
    class ListTestParams
    {
        public static readonly int ListInsertRemoveSize = 200000;
        public static readonly int ListAccessSize = 1000000;
    }
    
    class DynamicArrayAccessTimeTest : SomeTest
    {
        public DynamicArrayAccessTimeTest()
        {
            _name = "Динамический массив<int> последовательный доступ к элементам";
        }

        public override void Do()
        {
            List<int> list = new List<int>();
            
            for (int i = 0; i < ListTestParams.ListAccessSize; ++i)
            {
                list.Add(i);
            }

            StartTiming();
            for (int i = 0; i < 100; ++i)
            {
                for (int j = 0; j < list.Count; ++j)
                {
                    int x = list[j];
                }
            }
            StopTiming();            
        }
    }

    class DynamicArrayInsertRemoveTest : SomeTest
    {
        public DynamicArrayInsertRemoveTest()
        {
            _name = "Динамический массив<int> вставка/удаление элементов";
        }
        
        public override void Do()
        {            
            List<int> list = new List<int>();
            StartTiming();
            for (int i = 0; i < ListTestParams.ListInsertRemoveSize; ++i)
            {
                list.Add(i);
            }
            while (list.Count > 0)
            {
                list.RemoveAt(0);
            }
            StopTiming();
        }
    }

    class LinkedListAccessTimeTest : SomeTest
    {
        public LinkedListAccessTimeTest()
        {
            _name = "Связанный список<int> последовательный доступ к элементам";
        }

        public override void Do()
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < ListTestParams.ListAccessSize; ++i)
            {
                list.AddLast(i);
            }

            StartTiming();
            for (int i = 0; i < 100; ++i)
            {
                foreach (int value in list)
                {
                    int x = value;
                }
            }
            StopTiming();
        }
    }

    class LinkedListInsertRemoveTest : SomeTest
    {
        public LinkedListInsertRemoveTest()
        {
            _name = "Связанный список<int> вставка/удаление элементов";
        }
        
        public override void Do()
        {            
            LinkedList<int> list = new LinkedList<int>();
            StartTiming();
            for (int i = 0; i < ListTestParams.ListInsertRemoveSize; ++i)
            {
                list.AddLast(i);
            }
            while (list.Count > 0)
            {
                list.RemoveLast();
            }
            StopTiming();
        }
    }
}
