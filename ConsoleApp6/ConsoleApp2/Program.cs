using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int lines = int.Parse(Console.ReadLine());

            int output = 0;

            for (int i = 1; i <= lines; i++)
            {

                char input = char.Parse(Console.ReadLine());

                int sum = Convert.ToInt32(input);

                output += sum;

            }

            Console.WriteLine("The sum equals: {0}", output);
        }
    }
}
