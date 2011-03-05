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
            int iterationCount = 5;
            if (args.Length > 0)
            {
                if (!int.TryParse(args[0], out iterationCount))
                {
                    iterationCount = 5;
                }
            }
            Console.WriteLine("iterationCount = " + iterationCount);

            Tester testRunner = new Tester(iterationCount);
            testRunner.Do();
            testRunner.WriteResult();
        }
    }
}
