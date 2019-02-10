using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] arr1 = new int[arr.Length / 4];
            int[] arr2 = new int[arr.Length / 4];
            int[] arr3 = new int[arr.Length / 2];
            int[] polimerization = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[i];
            }
            Array.Reverse(arr);


            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr[i];
            }
            Array.Reverse(arr);

            for (int i = arr2.Length; i < arr3.Length + arr2.Length; i++)
            {
                arr3[i - arr2.Length] = arr[i];
            }
            Array.Reverse(arr1);

            for (int i = 0; i < arr1.Length; i++)
            {
                polimerization[i] = arr1[i];


            }

            for (int i = arr2.Length; i < arr3.Length ; i++)
            {
                polimerization[i] = arr2[i - arr2.Length];

            }

            for (int i = 0; i < arr3.Length; i++)
            {
                polimerization[i] += arr3[i];

                
            }
            string split = string.Join(" ", polimerization);
            Console.WriteLine(split);

        }
    }
}
