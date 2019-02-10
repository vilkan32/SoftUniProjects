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


            var first = int.Parse(Console.ReadLine());

            var second = int.Parse(Console.ReadLine());

            if (first> second)
            {
                for (int i = second; i <= first; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if(second > first)
            {
                for (int i = first; i <= second; i++)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
