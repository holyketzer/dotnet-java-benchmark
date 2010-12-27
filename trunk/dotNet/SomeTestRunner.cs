﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPerformance
{
    abstract class SomeTestRunner
    {
        protected List<SomeTest> _tests = new List<SomeTest>();
        
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
            foreach (SomeTest test in _tests)
            {
                Console.WriteLine("running test: " + test.Name);
                test.Do();
            }
        }

        public void WriteResult()
        {
            Console.WriteLine();
            Console.WriteLine(this.Name + ":");
            foreach (SomeTest test in _tests)
            {
                Console.WriteLine(test.Time + "\t ms. " + test.Name);
            }
        }
    }
}