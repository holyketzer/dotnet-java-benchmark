using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPerformance.RandomTests
{
    class IntRandomTest : SomeTest
    {
        public IntRandomTest()
        {
            _name = "Генерация случайных чисел int";
        }

        private Random rnd = new Random();

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < 100000000; ++i)
            {
                int x = rnd.Next();
            }
            StopTiming();            
        }
    }

    class DoubleRandomTest : SomeTest
    {
        public DoubleRandomTest()
        {
            _name = "Генерация случайных чисел double";
        }

        private Random rnd = new Random();

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < 100000000; ++i)
            {
                double x = rnd.NextDouble();
            }
            StopTiming();
        }
    }

    class RandomTestsRunner : SomeTestRunner
    {
        protected override void InitTests()
        {
            _name = "Генерация случайных чисел";
            
            _tests.Add(new IntRandomTest());
            _tests.Add(new DoubleRandomTest());
        }
    }
}
