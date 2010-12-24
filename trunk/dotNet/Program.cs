using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPerformanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestRunner testRunner = new TestRunner();
            testRunner.Do();
            testRunner.WriteResult();
        }
    }
}
