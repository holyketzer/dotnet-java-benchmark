using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DotNetPerformance.RandomTests;
using DotNetPerformance.CollectionsTests;

namespace DotNetPerformance
{
    class Tester
    {
        private List<SomeTestRunner> _testsRunners = new List<SomeTestRunner>();
        private int _totalLoops = 1;

        public Tester()
        {
            InitTestsRunners();
        }

        public Tester(int totalLoops)
        {
            _totalLoops = totalLoops;
            InitTestsRunners();
        }

        private void InitTestsRunners()
        {
            _testsRunners.Add(new RandomTestsRunner());
            _testsRunners.Add(new CollectionsTestsRunner());
        }

        public void Do()
        {
            Console.WriteLine("total loops = " + _totalLoops);
            
            for (int i = 0; i < _totalLoops; ++i)
            {
                Console.WriteLine("loop #" + (i+1).ToString());
                
                foreach (SomeTestRunner testRunner in _testsRunners)
                {
                    Console.WriteLine("running testgroup: " + testRunner.Name);
                    testRunner.Do();
                }
            }
        }

        public void WriteResult()
        {
            foreach (SomeTestRunner testRunner in _testsRunners)
            {
                testRunner.WriteResult();
            }
        }
    }
}
