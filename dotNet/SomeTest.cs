using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPerformanceTest
{
    public abstract class SomeTest
    {
        public abstract void Do();

        protected string _name = "";
        public string Name
        {
            get { return _name; }
        }

        protected int _time = 0;
        public int Time
        {
            get { return _time; }
        }

        protected void StartTiming()
        {
            _time = Environment.TickCount;
        }

        protected void StopTiming()
        {
            _time = Environment.TickCount - _time;
        }
    }
}
