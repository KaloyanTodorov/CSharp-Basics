using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToIntArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2 % 2);
            StringBuilder sb = new StringBuilder();
            string text = "new text";
            char[] textChars = text.ToCharArray();
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(string.Join("-", textChars));

        }
    }
}
