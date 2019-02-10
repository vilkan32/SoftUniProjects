using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Input = Console.ReadLine().Split(' ').ToList();
            string first = Input[0];
            string second = Input[1];
            long result = 0;
            int counter = 0;
            if (first.Count() > second.Count())
            {
                for (int i = 0; i < second.Count(); i++)
                {
                    result += first[i] * second[i];
                    counter++;
                }
                for (int i = counter; i < first.Count(); i++)
                {
                    result += first[i];
                }
              

            }
            else
            {

                for (int i = 0; i < first.Count(); i++)
                {
                    result += first[i] * second[i];
                    counter++;
                }
                for (int i = counter; i < second.Count(); i++)
                {
                    result += second[i];
                }
            }

            Console.WriteLine(result);


        }
    }
}
