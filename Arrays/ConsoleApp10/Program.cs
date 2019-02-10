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
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            int equalelementslefttoright = 0;
            int equalelementsrighttoleft = 0;

            for (int i = 0; i < Math.Min(arr.Length, arr1.Length); i++)
            {
                if (arr[i] == arr1[i])
                {
                    equalelementslefttoright++;
                }
            }
            Array.Reverse(arr);
            Array.Reverse(arr1);
            for (int i = 0; i < Math.Min(arr.Length, arr1.Length); i++)
            {
                
                 if (arr[i] == arr1[i])
                {
                    equalelementsrighttoleft++;
                }
            }

            Console.WriteLine(Math.Max(equalelementslefttoright,equalelementsrighttoleft));

        }
    }
}
