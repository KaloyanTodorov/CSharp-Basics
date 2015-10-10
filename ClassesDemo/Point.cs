using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Point
    {
        //Alternative to method public Point(int x, int y) {} is 



        //public Point(int x, int y)
        //{
        //    X = x;
        //    Y = y;
        //}

        public int X{ get;  set; }

        public int Y{ get; set; }

        public void Print()
        {
            Console.WriteLine("{0} - {1}", X, Y);
        }
    }
}
