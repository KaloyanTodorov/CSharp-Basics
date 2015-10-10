using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInTheRangeNM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (n > 1 && n > m)
            {
                for (int number = n; number <= m; number++)
                {
                    bool prime = true;
                    int divider = 2;
                    int maxDivider = (int)Math.Sqrt(number);

                    while (divider <= maxDivider)
                    {
                        if (number % divider == 0)
                        {
                            prime = false;
                            break;
                        }
                        divider++;
                    }
                    if (prime)
                    { Console.WriteLine("{0} ", number); }
            
                 }
            
            }
        }
    }
}
