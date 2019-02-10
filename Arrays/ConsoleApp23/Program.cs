using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int Max = arr.Max();
            int Min = arr.Min();

            Console.WriteLine("Min = {0}", Min);
            Console.WriteLine("Max = {0}", Max);
            TheSum(arr);
            Average(arr);




        }

        static void TheSum(int[] arr1)
        {
            int sum = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                 sum += arr1[i];

            }

            Console.WriteLine("Sum = {0}", sum);
        }
        static void Average(int[] arr1)
        {
            double sum = 0;
            double sum1 = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];

            }

            sum1 = sum / arr1.Length;

            Console.WriteLine("Average = {0}", sum1);
        }
    }
}
