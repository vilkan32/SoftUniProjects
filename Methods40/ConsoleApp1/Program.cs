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
            string input = Console.ReadLine();
            if (input == "int")
            {
                int input1 = int.Parse(Console.ReadLine());
                int input2 = int.Parse(Console.ReadLine());
                int[] list = new int[] { input1, input2 };
                Console.WriteLine(list.Max());

            }
            else if (input == "char")
            {
                char input1 = char.Parse(Console.ReadLine());
                char input2 = char.Parse(Console.ReadLine());
                char[] list = new char[] { input1, input2 };
                Console.WriteLine(list.Max());
            }
            else if (input == "string")
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                string[] list = new string[] { input1, input2 };
                Console.WriteLine(list.Max());
            }

        }
    }
}
