using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] people = new string[3];
            people[0] = "pesho";
            people[1] = "tesho";
            people[2] = "maria";

            Console.WriteLine(people[0]);
                
            for (int i = 0; i < people.Length; i++)
            {
                char lastChar = people[i][people[i].Length - 1];
                Console.WriteLine(lastChar);
                if (lastChar != 'a')
                {
                    people[i] += " Petrov";
                }
                else
                {
                    people[i] += " Petrova";
                }
            }

            foreach (string person in people)
            {

                Console.WriteLine(person);
            }
        }
    }
}
