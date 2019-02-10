using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> Input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var Output = new List<double>();
            if (Input.Count() % 2 != 0)
            {
                List<double> First = new List<double>();
                var Second = new List<double>();
                for (int i = 0; i < Input.Count() / 2; i++)
                {
                    First.Add(Input[i]);
                }
                Input.Reverse();
                for (int i = 0; i < Input.Count() / 2; i++)
                {
                    Second.Add(Input[i]);
                }

                for (int i = 0; i < Input.Count() / 2; i++)
                {
                    Output.Add(First[i] + Second[i]);
                }
                Output.Add(Input[Input.Count() / 2]);
            }
            else
            {
                List<double> First = new List<double>();
                var Second = new List<double>();
                for (int i = 0; i < Input.Count() / 2; i++)
                {
                    First.Add(Input[i]);
                }
                Input.Reverse();
                for (int i = 0; i < Input.Count() / 2; i++)
                {
                    Second.Add(Input[i]);
                }

                for (int i = 0; i < Input.Count() / 2; i++)
                {
                    Output.Add(First[i] + Second[i]);
                }
            }

            Console.WriteLine(string.Join(" ",Output));
        }
    }
}
