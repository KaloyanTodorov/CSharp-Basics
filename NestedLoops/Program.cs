using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int row = 1; row <= number; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write("{0}", column);
                }
                Console.WriteLine();
            }
        }
    }
}
