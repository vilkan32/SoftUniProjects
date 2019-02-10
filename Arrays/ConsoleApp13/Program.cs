using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long number = 1;

            bool[] primes = new bool[n + 1];

            for (int i = 0; i < primes.Length; i++)
            {

                primes[i] = true;

            }

            primes[0] = false;

            primes[1] = false;

            for (long p = 2; p < primes.Length; p++)
            {
                if (primes[p] == true)
                {
                    Console.Write(p + " ");
                    for (long i = 2; i < primes.Length; i++)
                    {
                        try
                        {
                            primes[i * p] = false;
                        }
                        catch (Exception)
                        {

                            break;
                        }
                    }
                }
               
            }

          

        }
    }
}
