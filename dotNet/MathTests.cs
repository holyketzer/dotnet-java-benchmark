using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPerformance.Math
{
    class Div10Test : SomeTest
    {
        public Div10Test()
        {
            _name = "Деление целых чисел на 10";
        }
        
        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < 1000000000; ++i)
            {
                int x = i / 10;
            }
            StopTiming();
        }
    }

    class SqrtTest : SomeTest
    {
        public SqrtTest()
        {
            _name = "Квадратный корень";
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < 1000000000; ++i)
            {
                double x = System.Math.Sqrt(i);
            }
            StopTiming();
        }
    }

    class SinTest : SomeTest
    {
        public SinTest()
        {
            _name = "Синус";
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < 1000000000; ++i)
            {
                double x = System.Math.Sin(i);
            }
            StopTiming();
        }
    }

    class CosTest : SomeTest
    {
        public CosTest()
        {
            _name = "Косинус";
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < 1000000000; ++i)
            {
                double x = System.Math.Cos(i);
            }
            StopTiming();
        }
    }

    class TanTest : SomeTest
    {
        public TanTest()
        {
            _name = "Тангенс";
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < 10000000; ++i)
            {
                double x = System.Math.Tan(i);
            }
            StopTiming();
        }
    }

    class Log10Test : SomeTest
    {
        public Log10Test()
        {
            _name = "Десятичный логарифм";
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < 10000000; ++i)
            {
                double x = System.Math.Log10(i);
            }
            StopTiming();
        }
    }

    class ExpTest : SomeTest
    {
        public ExpTest()
        {
            _name = "Экспонента";
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < 10000000; ++i)
            {
                double x = System.Math.Exp(i);
            }
            StopTiming();
        }
    }

    class AsinTest : SomeTest
    {
        public AsinTest()
        {
            _name = "Арксинус";
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < 10000000; ++i)
            {
                double x = System.Math.Asin(i);
            }
            StopTiming();
        }
    }

    class AcosTest : SomeTest
    {
        public AcosTest()
        {
            _name = "Арккосинус";
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < 10000000; ++i)
            {
                double x = System.Math.Acos(i);
            }
            StopTiming();
        }
    }

    class AtanTest : SomeTest
    {
        public AtanTest()
        {
            _name = "Арктангенс";
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < 10000000; ++i)
            {
                double x = System.Math.Atan(i);
            }
            StopTiming();
        }
    }
    
    class MathTestsRunner : SomeTestRunner
    {
        protected override void InitTests()
        {
            _name = "Математические";

            _tests.Add(new Div10Test());
            _tests.Add(new SqrtTest());
            _tests.Add(new SinTest());
            _tests.Add(new CosTest());
            _tests.Add(new TanTest());
            _tests.Add(new Log10Test());
            _tests.Add(new ExpTest());
            _tests.Add(new AsinTest());
            _tests.Add(new AcosTest());
            _tests.Add(new AtanTest());
        }
    }
}
