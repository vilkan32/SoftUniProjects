using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int M = int.Parse(Console.ReadLine());

            int stopnumber = int.Parse(Console.ReadLine());
            int B = 0; 

            int stop = 0;
            int broipreminavaniq = 0;

            for (int i = N; i >= 1; i--)
            {
                for (int a = 1; a <= M; a++)
                {
                    
                    if (stopnumber >= stop)
                    {
                        B = 3 * i * a;
                        stop += B;
                        broipreminavaniq++;
                        continue;
                        
                    }
                    else if(stopnumber < stop)
                    {
                        break;
                    }

                  
                }
            }

            if (stop >= stopnumber)
            {
                Console.WriteLine("{0} combinations", broipreminavaniq);
                Console.WriteLine("Sum: {0} >= {1}", stop, stopnumber);
            }
            else
            {
                Console.WriteLine("{0} combinations", broipreminavaniq);
                Console.WriteLine("Sum: {0}",stop);
            }





        }
    }
}
