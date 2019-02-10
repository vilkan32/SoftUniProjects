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
            int lines = int.Parse(Console.ReadLine());

            string word = "";

            for (int i = 1; i <= lines; i++)
            {
                string input = Console.ReadLine();
                word += input;

               
            }

            Console.WriteLine("The word is: {0}", word);
        }
    }
}
