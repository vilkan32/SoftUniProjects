using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = new int[2]; // even
            int[] arr3 = new int[3]; // odd
            string result = "";

            if (arr1.Length == 1)
            {
                result = string.Join("", arr1);
                Console.WriteLine("{ " + result + " }");

            }
            else if (arr1.Length%2 == 0) // even
            {
                // i = arr1.Length / 2 - 1; i <= arr1.Length 

                arr2[0] =arr1[arr1.Length / 2 - 1];
                arr2[1] = arr1[arr1.Length / 2];
                result = string.Join(" ,", arr2);
                Console.WriteLine("{ " + result + " }");
            }
            else if (arr1.Length % 2 != 0) // odd
            {
                //elements n/2-1, n/2, n/2+1
                arr3[0] = arr1[arr1.Length / 2 - 1];
                arr3[1] = arr1[arr1.Length / 2];
                arr3[2] = arr1[arr1.Length / 2 + 1];
                result = string.Join(" ,", arr3);
                Console.WriteLine("{ " + result + " }");

            }

            
            
         }
    }
}
