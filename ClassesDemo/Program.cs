using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Point[] points = 
            {
                new Point() {X = 2, Y = 15},                    // This is object.
                new Point() {X = -7, Y = 0},                    // This is object, too.
                new Point() {X = 5, Y = -25},
                new Point() {X = 1, Y = 9}
            };

            Point[] filtered = points
                .Where(p => p.X < 5)
                .ToArray();


            points[0] = new Point() { X = 28, Y = -55 };

            for (int i = 0; i < points.Length; i++)
            {
                points[i].X += 10;
                points[i].Print();
            }

            /*
            Point point = new Point(5, 10);
            //point.X = 5;
            //point.Y = 10;

            */

            Point point = new Point()               //Syntax!!!
            {
                X = 5,
                Y = 10
            };

            point.Print();
        }
    }
}
