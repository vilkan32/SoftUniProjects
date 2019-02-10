using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            char firstline = char.Parse(Console.ReadLine());

            string turn = Console.ReadLine();

            string output = "";

            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines ; i++)
            {

                string input = Console.ReadLine();
                if (turn == "even" && i % 2 == 0)
                {
                    output += input + firstline;

                }
                else if (turn == "odd" && i %2 != 0)
                {
                    output += input + firstline;
                }
            }

            int length = output.Length;

            output = output.Remove(length - 1);

            Console.WriteLine(output);
        }
    }
}
