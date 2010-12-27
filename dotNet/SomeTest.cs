using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPerformance
{
    public abstract class SomeTest
    {
        public abstract void Do();

        public void Reset()
        {
            _totalTime = 0;
            _count = 0;
        }

        protected string _name = "";
        public string Name
        {
            get { return _name; }
        }

        protected float _totalTime = 0;
        public float Time
        {
            get 
            {
                if (_count == 0)
                {
                    return 0;
                }
                else
                {
                    return _totalTime/_count; 
                }                
            }
        }

        protected int _lastStartTime = 0;
        protected int _count = 0;

        protected void StartTiming()
        {
            _lastStartTime = Environment.TickCount;
        }

        protected void StopTiming()
        {
            _totalTime += Environment.TickCount - _lastStartTime;
            ++_count;
        }
    }
}
