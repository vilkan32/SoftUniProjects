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

            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("After:");
            int tema = b;

            int tempb = a;
            Console.WriteLine("a = {0}", tema);
            Console.WriteLine("b = {0}", tempb);


        }
    }
}
