using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPerformance.Math
{
    public class MathTestParams 
    {
        public static readonly int iterationCount = 5000000;
    }
    
    class Div10Test : SomeTest
    {
        public Div10Test()
        {
            _name = "Деление целых чисел на 10";
            _iterationCount = MathTestParams.iterationCount * 10;
        }
        
        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < _iterationCount; ++i)
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
            _iterationCount = MathTestParams.iterationCount * 10;
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < _iterationCount; ++i)
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
            _iterationCount = MathTestParams.iterationCount * 5;
        }

        public override void Do()
        {
            double val = 0;
            double dt = System.Math.PI * 2;
            dt /= _iterationCount;

            StartTiming();
            for (int i = 0; i < _iterationCount; ++i)
            {
                double x = System.Math.Sin(val);
                val += dt;
            }
            StopTiming();
        }
    }

    class CosTest : SomeTest
    {
        public CosTest()
        {
            _name = "Косинус";
            _iterationCount = MathTestParams.iterationCount * 5;
        }

        public override void Do()
        {
            double val = 0;
            double dt = System.Math.PI * 2;
            dt /= _iterationCount;

            StartTiming();
            for (int i = 0; i < _iterationCount; ++i)
            {
                double x = System.Math.Cos(val);
                val += dt;
            }
            StopTiming();
        }
    }

    class TanTest : SomeTest
    {
        public TanTest()
        {
            _name = "Тангенс";
            _iterationCount = MathTestParams.iterationCount;
        }

        public override void Do()
        {
            double val = 0;
            double dt = System.Math.PI * 2;
            dt /= _iterationCount;

            StartTiming();
            for (int i = 0; i < _iterationCount; ++i)
            {
                double x = System.Math.Tan(val);
                val += dt;
            }
            StopTiming();
        }
    }

    class LogETest : SomeTest
    {
        public LogETest()
        {
            _name = "Натуральный логарифм";
            _iterationCount = MathTestParams.iterationCount;
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < _iterationCount; ++i)
            {
                double x = System.Math.Log(i);
            }
            StopTiming();
        }
    }

    class Log10Test : SomeTest
    {
        public Log10Test()
        {
            _name = "Десятичный логарифм";
            _iterationCount = MathTestParams.iterationCount;
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < _iterationCount; ++i)
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
            _iterationCount = MathTestParams.iterationCount;
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < _iterationCount; ++i)
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
            _iterationCount = MathTestParams.iterationCount;
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < _iterationCount; ++i)
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
            _iterationCount = MathTestParams.iterationCount;
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < _iterationCount; ++i)
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
            _iterationCount = MathTestParams.iterationCount;
        }

        public override void Do()
        {
            StartTiming();
            for (int i = 0; i < _iterationCount; ++i)
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
            _tests.Add(new LogETest());
            _tests.Add(new Log10Test());
            _tests.Add(new ExpTest());
            _tests.Add(new AsinTest());
            _tests.Add(new AcosTest());
            _tests.Add(new AtanTest());
        }
    }
}
