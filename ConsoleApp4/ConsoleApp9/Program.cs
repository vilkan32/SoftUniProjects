using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());

            int minutes = int.Parse(Console.ReadLine());


            if (minutes + 30 >= 60 && hour + 1 < 24)
            {
                Console.WriteLine("{0}:{1:d2}", hour + 1, minutes + 30 - 60);
            }
            else if (minutes + 30 >= 60 && hour + 1 == 24)
            {
                Console.WriteLine("{0}:{1:d2}", 0, minutes + 30 - 60);
            }
            else
            {
                Console.WriteLine("{0}:{1:d2}", hour, minutes + 30 );
            
            }
            



        }
    }
}
