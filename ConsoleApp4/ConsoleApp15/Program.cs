using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            
            for (int i = 0; i < 10; i++)
            {
                int odd = int.Parse(Console.ReadLine());
                if (odd % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");

                }
                else
                {
                    Console.WriteLine("The number is: {0}", Math.Abs(odd));
                    break;
                }
            }
           




        }
    }
}
