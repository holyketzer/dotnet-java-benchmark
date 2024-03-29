﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPerformance
{
    abstract class SomeTestRunner
    {
        protected List<SomeTest> _tests = new List<SomeTest>();
		private long _maxTotalMemory = 0;
        
        public SomeTestRunner()
        {
            InitTests();
        }

        protected abstract void InitTests();

        protected string _name = "";
        public string Name
        {
            get { return _name; }
        }
        
        public void Do()
        {
            Console.WriteLine();
            Console.WriteLine("running testgroup: " + this.Name);
            foreach (SomeTest test in _tests)
            {
                Console.WriteLine("running test: " + test.Name);
                test.Do();
				_maxTotalMemory = System.Math.Max(GC.GetTotalMemory(false), _maxTotalMemory);
            }
        }

        public void WriteResult()
        {
            Console.WriteLine();
            Console.WriteLine(this.Name + ":");
            foreach (SomeTest test in _tests)
            {
                Console.WriteLine(String.Format("{0:F5}_op/mks_{1:F2}_ms._{2:E0}_{3}", test.Score, test.Time, test.IterationCount, test.Name));
            }
        }
		
		public long GetMaxTotalMemory()
		{
			return _maxTotalMemory;
		}
    }
}
