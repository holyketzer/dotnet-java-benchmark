using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotNet_random
{
    class Program
    {
        static void Main(string[] args)
        {            
            Random rnd = new Random();
            int totalLoop = 5;
            
            double randomTime = 0;
            double listAddTime = 0;

            for (int total = 0; total < totalLoop; ++total)
            {                
                int start = Environment.TickCount;
                /*for (int i = 0; i < 100000000; ++i)
                {
                    double x = rnd.NextDouble();
                }
                start = Environment.TickCount - start;
                randomTime += start;                
                */
                start = Environment.TickCount;
                LinkedList<int> list = new LinkedList<int>();
                for (int i = 0; i < 100000; ++i)
                {
                    list.AddLast(i);
                }
                while (list.Count > 0)
                {
                    list.RemoveLast();
                }
                start = Environment.TickCount - start;
                listAddTime += start;                
            }

            //System.Collections.Generic.

            Console.WriteLine("random test = " + randomTime / totalLoop + " ms.");
            Console.WriteLine("list<int> add test = " + listAddTime / totalLoop + " ms.");
        }
    }
}
