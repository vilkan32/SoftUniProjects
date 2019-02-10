using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] arr1 = new int[arr.Length];

            int[] sum = new int[arr.Length];

            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                arr1[0] = arr[arr.Length - 1];
                for (int i = 1; i < arr.Length ; i++)
                {

                    arr1[i] = arr[i - 1];

                    

                }
                for (int i = 0; i < arr.Length ; i++)
                {
                    arr[i] = arr1[i];

                }

                for (int i = 0; i < arr.Length ; i++)
                {
                    sum[i] += arr1[i];

                }

                num--;
            }


            string result = string.Join(" ", sum);
            Console.WriteLine(result);

        }
    }
}
