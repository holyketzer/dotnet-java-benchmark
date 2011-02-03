using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPerformance.ArraysTests
{
    public class ArrayTestParams 
    {
	    public static readonly int arraySize = 50000000; 
    }
    
    class ArrayIntCreateTest : SomeTest
    {
        public ArrayIntCreateTest()
        {
            _name = "int[] создание и заполнение массива";
            _iterationCount = ArrayTestParams.arraySize;
        }
        
        public override void Do()
        {
            int[] array = null;
            while (array == null)
            {
                try
                {
                    StartTiming();
                    array = new int[_iterationCount];
                }
                catch (OutOfMemoryException)
                {
                    _iterationCount /= 2;
                    Console.WriteLine("!! Недостаточно памяти для полного теста");
                }
            }

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
            _iterationCount = ArrayTestParams.arraySize;
        }

        public override void Do()
        {
            int[] array = null;
            while (array == null)
            {
                try
                {
                    array = new int[_iterationCount];
                }
                catch (OutOfMemoryException)
                {
                    _iterationCount /= 2;
                    Console.WriteLine("!! Недостаточно памяти для полного теста");
                }
            }

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
            _iterationCount = ArrayTestParams.arraySize;
        }

        public override void Do()
        {
            double[] array = null;
		    while (array == null)
		    {
			    try
			    {
				    StartTiming();
                    array = new double[_iterationCount];
                }
                catch (OutOfMemoryException)
                {
                    _iterationCount /= 2;
                    Console.WriteLine("!! Недостаточно памяти для полного теста");
                }
            }
            
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
            double[] array = null;
            while (array == null)
            {
                try
                {

                    array = new double[_iterationCount];
                }
                catch (OutOfMemoryException)
                {
                    _iterationCount /= 2;
                    Console.WriteLine("!! Недостаточно памяти для полного теста");
                }
            }

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
