using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;
namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Queue<int> razlika = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
               var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                razlika.Enqueue(input[0] - input[1]);   
            }
            int index = 0;
            while (true)
            {
                int fuel = 0;
                for (int i = 0; i < n; i++)
                {
                    fuel += razlika.ElementAt(i);
                    if (fuel < 0)
                    {
                        index++;
                        razlika.Enqueue(razlika.Dequeue());
                        break;
                    }
                }
                if (fuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
