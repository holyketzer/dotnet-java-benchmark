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
            _name = "Создние и заполнение одномерного массива int[]";
        }
        
        public override void Do()
        {
            StartTiming();
            int[] array = new int[50000000];
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
            _name = "Последовательный доступ к элементам одномерного массива int[]";
        }

        public override void Do()
        {            
            int[] array = new int[50000000];
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
            _name = "Создние и заполнение одномерного массива double[]";
        }

        public override void Do()
        {
            StartTiming();
            double[] array = new double[50000000];
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
            _name = "Последовательный доступ к элементам одномерного массива double[]";
        }

        public override void Do()
        {
            double[] array = new double[50000000];
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
