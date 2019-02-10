using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examsequence1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstOne = int.Parse(Console.ReadLine());

            int secondOne = int.Parse(Console.ReadLine());

            int thirdOne = int.Parse(Console.ReadLine());
            int totalMonkeys = int.Parse(Console.ReadLine());
            int initialstate = totalMonkeys;
            int monkeysPerHour = firstOne + secondOne + thirdOne;
            int hours = 0;
            for (int i = 1; i <= 4; i++)
            {
                if (i == 4)
                {
                    i = 0;
                    hours++;
                    continue;
                    
                }
                totalMonkeys -= monkeysPerHour;
                hours++;
                if (totalMonkeys <=0)
                {
                    break;
                }
                

            }
            if (initialstate == 0)
            {
                Console.WriteLine("Time needed: 0h.");
            }
            else
            Console.WriteLine("Time needed: {0}h.", hours);
        }
    }
}
