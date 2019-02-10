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

            int number = 0;


            for (int i = 0; i < 100; i++)
            {
               
                string ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", number);
                    break;
                }
                number++;
                Console.WriteLine("Adding ingredient {0}.", ingredient);
                
            }
        }
    }
}
