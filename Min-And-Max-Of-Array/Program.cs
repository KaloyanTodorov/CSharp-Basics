using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_And_Max_Of_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int? maxVal = null; //nullable so this works even if you have all super-low negatives
            int index = -1;
            int[] anArray = new int[1];
            for (int i = 0; i < anArray.Length; i++)
            {
                int thisNum = anArray[i];
                if (!maxVal.HasValue || thisNum > maxVal.Value)
                {
                    maxVal = thisNum;
                    index = i;
                }
            }
        }
    }
}
