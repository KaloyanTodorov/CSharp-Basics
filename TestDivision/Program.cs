using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            decimal result = 1;
            for (int i = 0; i < m; ++i)
            {
                result *= n;
            }
            Console.WriteLine(result);
        }
    }
}
