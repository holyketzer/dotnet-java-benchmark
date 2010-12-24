using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPerformanceTest
{
    class TestRunner
    {
        private List<SomeTest> _tests = new List<SomeTest>();
        
        public TestRunner()
        {
            _tests.Add(new IntRandomTest());
            _tests.Add(new DoubleRandomTest());
            _tests.Add(new DynamicArrayAccessTimeTest());
            _tests.Add(new DynamicArrayInsertRemoveTest());
            _tests.Add(new LinkedListAccessTimeTest());
            _tests.Add(new LinkedListInsertRemoveTest());
        }
        
        public void Do()
        {
            foreach (SomeTest test in _tests)
            {
                Console.WriteLine("running test: " + test.Name);
                test.Do();
            }
        }

        public void WriteResult()
        {
            Console.WriteLine();
            foreach (SomeTest test in _tests)
            {
                Console.WriteLine(test.Time + "\t ms. " + test.Name);
            }
        }
    }
}
