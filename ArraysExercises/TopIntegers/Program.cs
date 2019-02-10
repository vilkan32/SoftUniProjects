using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string Output = "";
            for (int i = 0; i < Input.Count(); i++)
            {
                int elementToCompare = Input[i];
                int counter = 0;
                for (int x = i + 1; x < Input.Count(); x++)
                {
                    if (elementToCompare > Input[x])
                    {
                        continue;
                    }
                    else
                    {
                      counter++;
                        break;
                    }
                }

                if (counter == 0)
                {
                    Output += elementToCompare + " "; 
                }
               
            }
            Console.WriteLine(Output.TrimEnd());
        }
    }
}
