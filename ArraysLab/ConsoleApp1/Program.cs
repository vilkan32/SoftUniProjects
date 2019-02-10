using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int couneter = 0;
            while (Input.Count() > 1)
            {
                couneter++;
                List<int> TemporaryVariables = new List<int>();

                for (int i = 0; i < Input.Count() - 1; i++)
                {
                    TemporaryVariables.Add(Input[i] + Input[i + 1]);
                }

                Input = TemporaryVariables;
            }

            if (couneter == 0)
            {
                Console.WriteLine("{0}", Input[0]);
            }
            else
            {
                Console.WriteLine(Input[0]);
            }
            
        }
    }
}
