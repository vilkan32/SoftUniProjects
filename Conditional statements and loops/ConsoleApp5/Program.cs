using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberscount = 0;
            for (int i = 0; i < 100; i++)
            {
                

                try
                {
                    int numbers = int.Parse(Console.ReadLine());
                    numberscount += 1;
                }
                catch (Exception)
                {
                    Console.WriteLine(numberscount);
                    break ;
                }     
            }
        }
    }
}
