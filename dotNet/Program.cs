using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester testRunner = new Tester();
            testRunner.Do();
            testRunner.WriteResult();
        }
    }
}
