using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(' ');

            Queue<string> Cars = new Queue<string>(input);
            Stack<string> Served = new Stack<string>();
            while (true)
            {

                string[] command = Console.ReadLine().Split('-').ToArray();

                if (Cars.Any() && command[0] == "Service")
                {
                    Served.Push(Cars.Peek());
                    Console.WriteLine("Vehicle {0} got served.", Cars.Dequeue());
                }
                else if (command[0] == "CarInfo")
                {
                    if (Cars.Contains(command[1]))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (command[0] == "History")
                {
                    Console.WriteLine(string.Join(", ", Served));
                }
                else if (command[0] == "End")
                {
                    break;
                }

            }

            if (Cars.Any())
            {
                Console.WriteLine("Vehicles for service: {0}", string.Join(", ", Cars));
            }
          
                Console.WriteLine("Served vehicles: {0}", string.Join(", ", Served));
            

        }
    }
}
