using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPerformance.StringConversions
{
    public class StringConversionsTestParams
    { 
        public static readonly int iterationCount = 10000000;
    }

    class IntParseTest : SomeTest
    {
        public IntParseTest()
        {
            _name = "Парсинг int";
            _iterationCount = StringConversionsTestParams.iterationCount / 10;
        }

        public override void Do()
        {
            string[] arr = new string[_iterationCount];

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = i.ToString();
            }

            StartTiming();
            for (int i = 0; i < arr.Length; ++i)
            {
                int x = int.Parse(arr[i]);
            }
            StopTiming();
        }
    }

    class FloatParseTest : SomeTest
    {
        public FloatParseTest()
        {
            _name = "Парсинг float";
            _iterationCount = StringConversionsTestParams.iterationCount / 20;
        }

        public override void Do()
        {
            string[] arr = new string[_iterationCount];

            for (int i = 0; i < arr.Length; ++i)
            {
                float x = i;
                x = x / 123 + i;
                arr[i] = x.ToString();
            }

            StartTiming();
            for (int i = 0; i < arr.Length; ++i)
            {
                float x = float.Parse(arr[i]);
            }
            StopTiming();
        }
    }

    class DoubleParseTest : SomeTest
    {
        public DoubleParseTest()
        {
            _name = "Парсинг double";
            _iterationCount = StringConversionsTestParams.iterationCount / 20;
        }

        public override void Do()
        {
            string[] arr = new string[_iterationCount];

            for (int i = 0; i < arr.Length; ++i)
            {
                double x = i;
                x = x / 123 + i;
                arr[i] = x.ToString();
            }

            StartTiming();
            for (int i = 0; i < arr.Length; ++i)
            {
                double x = double.Parse(arr[i]);
            }
            StopTiming();
        }
    }

    class IntToStringTest : SomeTest
    {
        public IntToStringTest()
        {
            _name = "int.ToString()";
            _iterationCount = StringConversionsTestParams.iterationCount;
        }

        public override void Do()
        {            
            StartTiming();
            for (int i = 0; i < _iterationCount; ++i)
            {
                string s = i.ToString();
            }
            StopTiming();            
        }
    }

    class FloatToStringTest : SomeTest
    {
        public FloatToStringTest()
        {
            _name = "float.ToString()";
            _iterationCount = StringConversionsTestParams.iterationCount/10;
        }

        public override void Do()
        {
            float[] arr = new float[_iterationCount];

            for (int i = 0; i < arr.Length; ++i)
            {
                float x = i;
                arr[i] = x / 123 + i;
            }

            StartTiming();
            for (int i = 0; i < arr.Length; ++i)
            {
                string s = arr[i].ToString();
            }
            StopTiming();
        }
    }

    class DoubleToStringTest : SomeTest
    {
        public DoubleToStringTest()
        {
            _name = "double.ToString()";
            _iterationCount = StringConversionsTestParams.iterationCount/10;
        }

        public override void Do()
        {
            double[] arr = new double[_iterationCount];

            for (int i = 0; i < arr.Length; ++i)
            {
                double x = i;
                arr[i] = x / 123 + i;
            }

            StartTiming();
            for (int i = 0; i < arr.Length; ++i)
            {
                string s = arr[i].ToString();
            }
            StopTiming(); 
        }
    }

    class StringConcatTest : SomeTest
    {
        public StringConcatTest()
        {
            _name = "Конкатенация строк";
            _iterationCount = StringConversionsTestParams.iterationCount / 500;
        }

        public override void Do()
        {
            string[] arr = new string[_iterationCount];

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = i.ToString();
            }

            StartTiming();
            string s = "";
            for (int i = 0; i < arr.Length; ++i)
            {
                s += arr[i];
            }
            StopTiming();
        }
    }

    class StringBuilderConcatTest : SomeTest
    {
        public StringBuilderConcatTest()
        {
            _name = "Конкатенация строк в StringBuilder";
            _iterationCount = StringConversionsTestParams.iterationCount / 2;
        }

        public override void Do()
        {
            string[] arr = new string[_iterationCount];

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = i.ToString();
            }

            StartTiming();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.Length; ++i)
            {
                sb.Append(arr[i]);
            }
            string s = sb.ToString();
            StopTiming();
        }
    }

    class StringSubstringTest : SomeTest
    {
        public StringSubstringTest()
        {
            _name = "Выделение подстрок";
            _iterationCount = StringConversionsTestParams.iterationCount / 1000;
        }

        public override void Do()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _iterationCount; ++i)
            {
                sb.Append(i.ToString());
            }
            string s = sb.ToString();

            StartTiming();
            
            while (s.Length > 0)
            {
                s = s.Substring(0, s.Length-1);
            }
            StopTiming();
        }
    }

    class StringBuilderRemoveTest : SomeTest
    {
        public StringBuilderRemoveTest()
        {
            _name = "Удаление символов из StringBuilder";
            _iterationCount = StringConversionsTestParams.iterationCount / 10;
        }

        public override void Do()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _iterationCount; ++i)
            {
                sb.Append(i.ToString());
            }

            StartTiming();
            while (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            StopTiming();
        }
    }

    class StringReplaceTest : SomeTest
    {
        public StringReplaceTest()
        {
            _name = "Замена символов в string";
            _iterationCount = StringConversionsTestParams.iterationCount / 20;
        }

        public override void Do()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _iterationCount; ++i)
            {
                sb.Append(i.ToString());
            }
            string s = sb.ToString();

            StartTiming();
            for (int i = 0; i < 10; ++i)
            {
                s = s.Replace(i.ToString(), "+");
            }
            StopTiming();
        }
    }

    class StringBuilderReplaceTest : SomeTest
    {
        public StringBuilderReplaceTest()
        {
            _name = "Замена символов в StringBuilder";
            _iterationCount = StringConversionsTestParams.iterationCount / 10;
        }

        public override void Do()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _iterationCount; ++i)
            {
                sb.Append(i.ToString());
            }

            StartTiming();
            for (int i = 0; i < 10; ++i)
            {
                sb = sb.Replace(i.ToString(), "+");
            }
            StopTiming();
        }
    }

    class StringConversionsTestRunner : SomeTestRunner
    {
        protected override void InitTests()
        {
            _name = "Строковые преобразования";

            _tests.Add(new IntParseTest());
            _tests.Add(new FloatParseTest());
            _tests.Add(new DoubleParseTest());
            _tests.Add(new IntToStringTest());
            _tests.Add(new FloatToStringTest());
            _tests.Add(new DoubleToStringTest());
            _tests.Add(new StringConcatTest());
            _tests.Add(new StringBuilderConcatTest());
            _tests.Add(new StringSubstringTest());
            _tests.Add(new StringBuilderRemoveTest());
            _tests.Add(new StringReplaceTest());
            _tests.Add(new StringBuilderReplaceTest());
        }
    }
}
