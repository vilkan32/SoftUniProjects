using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string lastname = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, {0} {1}.\r\nYou are {2} years old.", name, lastname,age);




        }
    }
}
