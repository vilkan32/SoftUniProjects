using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            int length = int.Parse(Console.ReadLine());

            string output = "";

            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == length)
                {
                    Console.WriteLine("Adding {0}.", arr[i]);
                    output += string.Join(" ", arr[i]) + ", ";
                    counter++;
                }


                 if (counter == 10)
                {
                    break;
                }

            }

            Console.WriteLine("Made pizza with total of {0} ingredients.", counter);
            output = output.TrimEnd(' ');
            output = output.TrimEnd(',');
            output = output + '.';
            Console.WriteLine("The ingredients are: {0}", output);

        }
    }
}
