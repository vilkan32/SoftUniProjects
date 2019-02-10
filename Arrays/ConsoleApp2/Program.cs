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
            int k = int.Parse(Console.ReadLine());

            long[] arr = new long[n];

            arr[0] = 1;

            for (int i = 1; i < n; i++)
            {

                long number = 0;
                for (int r = i - k; r <= i - 1; r++)
                {
                    if (r >= 0)
                    {
                        number += arr[r];
                        
                    }
                    arr[i] = number;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
                
            }
            Console.WriteLine();

        }
    }
}
