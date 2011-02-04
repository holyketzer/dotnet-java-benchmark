using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPerformance.CollectionsTests
{
    class ListTestParams
    {
        public static readonly int ListInsertRemoveSize = 500000;
        public static readonly int ListAccessSize = 2000000;
    }
    
    class DynamicArrayAccessTimeTest : SomeTest
    {
        public DynamicArrayAccessTimeTest()
        {
            _name = "DynamicArray<int> последовательный доступ к элементам";
            _iterationCount = ListTestParams.ListAccessSize;
            _iterationCoeff = 100;
        }

        public override void Do()
        {
            List<int> list = new List<int>();

            for (int i = 0; i < _iterationCount; ++i)
            {
                list.Add(i);
            }
            
            StartTiming();
            for (int i = 0; i < _iterationCoeff; ++i)
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
            _name = "DynamicArray<int> вставка и удаление элементов";
            _iterationCount = ListTestParams.ListInsertRemoveSize / 4;
        }
        
        public override void Do()
        {            
            List<int> list = new List<int>();
            StartTiming();
            for (int i = 0; i < _iterationCount; ++i)
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
            _name = "LinkedList<int> последовательный доступ к элементам";
            _iterationCount = ListTestParams.ListAccessSize;
            _iterationCoeff = 100;
        }

        public override void Do()
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < _iterationCount; ++i)
            {
                list.AddLast(i);
            }

            StartTiming();
            for (int i = 0; i < _iterationCoeff; ++i)
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
            _name = "LinkedList<int> вставка и удаление элементов";
            _iterationCount = ListTestParams.ListInsertRemoveSize * 10;
        }
        
        public override void Do()
        {            
            LinkedList<int> list = new LinkedList<int>();
            StartTiming();
            for (int i = 0; i < _iterationCount; ++i)
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

    class StackInsertRemoveTest : SomeTest
    {
        public StackInsertRemoveTest()
        {
            _name = "Stack<int> вставка и удаление элементов";
            _iterationCount = ListTestParams.ListInsertRemoveSize * 20;
        }

        public override void Do()
        {
            Stack<int> stack = new Stack<int>();
            StartTiming();
            try
            {
                for (int i = 0; i < _iterationCount; ++i)
                {
                    stack.Push(i);
                }
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("!! Недостаточно памяти для полного теста");
                _iterationCount = stack.Count;
            }
          
            for (int i = 0; i < _iterationCount; ++i)
            {
                int x = stack.Pop();
            }
            StopTiming();
        }
    }

    class QueueInsertRemoveTest : SomeTest
    {
        public QueueInsertRemoveTest()
        {
            _name = "Queue<int> вставка и удаление элементов";
            _iterationCount = ListTestParams.ListInsertRemoveSize * 10;
        }
        
        public override void Do()
        {
            Queue<int> stack = new Queue<int>();
            StartTiming();
            try
            {
                for (int i = 0; i < _iterationCount; ++i)
                {
                    stack.Enqueue(i);
                }
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("!! Недостаточно памяти для полного теста");
                _iterationCount = stack.Count;
            }

            for (int i = 0; i < _iterationCount; ++i)
            {
                int x = stack.Dequeue();
            }
            StopTiming();
        }
    }

    class DictionaryInsertRemoveTest : SomeTest
    {
        public DictionaryInsertRemoveTest()
        {
            _name = "Dictionary<int, string> вставка и удаление элементов";
            _iterationCount = ListTestParams.ListInsertRemoveSize * 2;
        }
        
        public override void Do()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();

            StartTiming();
            try
            {
                for (int i = 0; i < _iterationCount; ++i)
                {
                    dic.Add(i, i.ToString());
                }
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("!! Недостаточно памяти для полного теста");
                _iterationCount = dic.Count;
            }

            while (dic.Count > 0)
            {
                dic.Remove(dic.Count - 1);
            }

            StopTiming();
        }
    }

    class DictionaryAccessTimeTest : SomeTest
    {
        public DictionaryAccessTimeTest()
        {
            _name = "Dictionary<int, string> последовательный доступ к элементам";
            _iterationCount = ListTestParams.ListAccessSize * 5;
        }

        public override void Do()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
                        
            try
            {
                for (int i = 0; i < _iterationCount; ++i)
                {
                    dic.Add(i, i.ToString());
                }
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("!! Недостаточно памяти для полного теста");
                _iterationCount = dic.Count;
            }

            StartTiming();
            for (int i = 0; i < dic.Count; ++i)
            {
                string x = dic[i];
            }
            StopTiming();
        }
    }

    class CollectionsTestsRunner : SomeTestRunner
    {
        protected override void InitTests()
        {
            _name = "Коллекции";

            _tests.Add(new DynamicArrayAccessTimeTest());
            _tests.Add(new DynamicArrayInsertRemoveTest());
            _tests.Add(new LinkedListAccessTimeTest());
            _tests.Add(new LinkedListInsertRemoveTest());
            _tests.Add(new StackInsertRemoveTest());
            _tests.Add(new QueueInsertRemoveTest());
            _tests.Add(new DictionaryInsertRemoveTest());
            _tests.Add(new DictionaryAccessTimeTest());
        }
    }
}
