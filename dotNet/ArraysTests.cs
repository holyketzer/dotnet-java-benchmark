using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPerformance.ArraysTests
{
    class ArrayIntCreateTest : SomeTest
    {
        public ArrayIntCreateTest()
        {
            _name = "int[] создание и заполнение массива";
            _iterationCount = 50000000;
        }
        
        public override void Do()
        {
            StartTiming();
            int[] array = new int[_iterationCount];
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = i;
            }
            StopTiming();
        }
    }

    class ArrayIntAccessTest : SomeTest
    {
        public ArrayIntAccessTest()
        {
            _name = "int[] последовательный доступ к элементам";
            _iterationCount = 50000000;
        }

        public override void Do()
        {
            int[] array = new int[_iterationCount];
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = i;
            }

            StartTiming();
            for (int i = 0; i < array.Length; ++i)
            {
                int x = array[i];
            }
            for (int i = array.Length - 1; i > 0; --i)
            {
                int x = array[i];
            }
            StopTiming();
        }
    }

    class ArrayDoubleCreateTest : SomeTest
    {
        public ArrayDoubleCreateTest()
        {
            _name = "double[] создание и заполнение массива";
            _iterationCount = 50000000;
        }

        public override void Do()
        {
            StartTiming();
            double[] array = new double[_iterationCount];
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = i;
            }
            StopTiming();
        }
    }

    class ArrayDoubleAccessTest : SomeTest
    {
        public ArrayDoubleAccessTest()
        {
            _name = "double[] последовательный доступ к элементам";
            _iterationCount = 50000000;
        }

        public override void Do()
        {
            double[] array = new double[_iterationCount];
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = i;
            }

            StartTiming();
            for (int i = 0; i < array.Length; ++i)
            {
                double x = array[i];
            }
            for (int i = array.Length - 1; i > 0; --i)
            {
                double x = array[i];
            }
            StopTiming();
        }
    }
    
    class ArraysTestsRunner : SomeTestRunner
    {
        protected override void InitTests()
        {
            _name = "Массивы";

            _tests.Add(new ArrayIntCreateTest());
            _tests.Add(new ArrayIntAccessTest());
            _tests.Add(new ArrayDoubleCreateTest());
            _tests.Add(new ArrayDoubleAccessTest());
        }
    }
}
