using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DigitNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1000; i <= 9999; i++)
            {
                string num = i.ToString();
                int a = int.Parse(num[0].ToString());
                int b = int.Parse(num[1].ToString());
                int c = int.Parse(num[2].ToString());
                int d = int.Parse(num[3].ToString());
                if ((a + b) == (c + d))
                {
                    Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
                }
            }



            //for (int A = 1; A <= 9; A++)
            //{
            //    for (int B = 0; B <= 9; B++)
            //    {
            //        for (int C = 0; C <= 9; C++)
            //        {
            //            for (int D = 0; D <= 9; D++)
            //            {
            //                if ((A + B) == (C + D) )
            //                {
            //                    Console.WriteLine("{0}{1}{2}{3}",A ,B, C, D);
            //                }
            //            }   
            //        }
            //    }   
            //}
        }
    }
}
