using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int firsthalf = (n - 1) / 2;

            int middlespaces = n - 4;

            int secondhalf = firsthalf;

            Console.WriteLine("x{0}x",new string(' ', n-2));

            if (n-2>1)
            {
                for (int i = 1; i <= firsthalf; i++)
                {

                    if (i< firsthalf)
                    {
                        Console.WriteLine("{0}x{1}x", new string(' ', i), new string(' ', middlespaces));
                        middlespaces -= 2;
                    }
                    else
                    {
                        Console.WriteLine("{0}x", new string(' ',firsthalf));
                    }

                }
            }
            else
            {
                Console.WriteLine("{0}x", new string(' ', firsthalf));
            }

            for (int y = 1; y <= firsthalf; y++)
            {
                secondhalf -= 1;
                middlespaces += 2;
                Console.WriteLine("{0}x{1}x",new string(' ', secondhalf), new string(' ', middlespaces));
                
            }


        }
    }
}
