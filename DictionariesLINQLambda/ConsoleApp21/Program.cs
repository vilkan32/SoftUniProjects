using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {

            

            string input = Console.ReadLine();
            List<string> Input = input.Split(' ').ToList();
            Input.Sort();

            Console.WriteLine(string.Join(", ", Input));
             



        }
    }
}
