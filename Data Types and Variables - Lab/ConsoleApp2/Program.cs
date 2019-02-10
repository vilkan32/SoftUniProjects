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

            int n = int.Parse(Console.ReadLine());

            int liters = 0;

            for (int i = 0; i < n; i++)
            {

                int litestopour = int.Parse(Console.ReadLine());
                liters += litestopour;
               
                if (liters > 255)
                {
                    liters -= litestopour;
                    Console.WriteLine("Insufficient capacity!");
                }


            }

            Console.WriteLine(liters);

        }
    }
}
