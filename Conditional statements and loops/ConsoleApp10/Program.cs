using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int npersons = int.Parse(Console.ReadLine());

            int capacity = int.Parse(Console.ReadLine());

            int courses = 0;
            int prevozenihora = 0;

            
                if (npersons > capacity)
                {
                    courses = npersons / capacity;
                prevozenihora = capacity * courses;
                
                }
                else
                {
                    Console.WriteLine("Only one course is needed.");
                }

            if (prevozenihora < npersons)
            {
                courses += 1;
                
            }


            Console.WriteLine(courses);

        }
    }
}
