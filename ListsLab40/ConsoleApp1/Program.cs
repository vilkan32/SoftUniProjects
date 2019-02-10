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

            List<int> Input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> Output = new List<int>();

            for (int i = 0; i < Math.Min(Input.Count(), Input1.Count()); i++)
            {
                Output.Add(Input[i]);
                Output.Add(Input1[i]);
            }

            if (Math.Min(Input.Count(), Input1.Count()) == Input.Count())
            {
                for (int i = Math.Min(Input.Count(), Input1.Count()); i < Input1.Count(); i++)
                {
                    Output.Add(Input1[i]);
                }
            }
            else if (Math.Min(Input.Count(), Input1.Count()) == Input1.Count())
            {
                for (int i = Math.Min(Input.Count(), Input1.Count()); i < Input.Count(); i++)
                {
                    Output.Add(Input[i]);
                }
            }

            Console.WriteLine(string.Join(" ", Output));
        }
    }
}
