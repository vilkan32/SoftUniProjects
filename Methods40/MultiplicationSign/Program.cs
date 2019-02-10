using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputFirst = Console.ReadLine();
            string inputSecond = Console.ReadLine();
            string inputThird = Console.ReadLine();
            int numberofnegativenumbers = 0;
            if (inputFirst.StartsWith("-"))
            {
                numberofnegativenumbers++;
            }
            if (inputSecond.StartsWith("-"))
            {
                numberofnegativenumbers++;
            }
            if (inputThird.StartsWith("-"))
            {
                numberofnegativenumbers++;
            }

            if (inputThird == "0" || inputSecond == "0"|| inputFirst == "0")
            {
                Console.WriteLine("zero");
            }
            else
            {
                if (numberofnegativenumbers% 2 == 0)
                {
                    Console.WriteLine("positive");
                }
                else
                {
                    Console.WriteLine("negative");
                }
            }



        }
    }
}
