﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DotNetPerformance.ArraysTests;
using DotNetPerformance.CollectionsTests;
using DotNetPerformance.Math;
using DotNetPerformance.RandomTests;
using DotNetPerformance.StringConversions;

namespace DotNetPerformance
{
    class Tester
    {
        private List<SomeTestRunner> _testsRunners = new List<SomeTestRunner>();
        private int _totalLoops = 1;
		private long _maxTotalMemory = 0;

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
            _testsRunners.Add(new MathTestsRunner());
            _testsRunners.Add(new RandomTestsRunner());
            _testsRunners.Add(new ArraysTestsRunner());
            _testsRunners.Add(new CollectionsTestsRunner());
            _testsRunners.Add(new StringConversionsTestRunner());
        }

        public void Do()
        {
            Console.WriteLine("total loops = " + _totalLoops);
            
            for (int i = 0; i < _totalLoops; ++i)
            {
                Console.WriteLine();
                Console.WriteLine("loop #" + (i+1).ToString());
                
                foreach (SomeTestRunner testRunner in _testsRunners)
                {
                    testRunner.Do();
                }
            }
        }

        public void WriteResult()
        {
            foreach (SomeTestRunner testRunner in _testsRunners)
            {
                testRunner.WriteResult();
				_maxTotalMemory = System.Math.Max(testRunner.GetMaxTotalMemory(), _maxTotalMemory);
            }
			Console.WriteLine("MaxTotalMemory: " + _maxTotalMemory);
        }
    }
}
