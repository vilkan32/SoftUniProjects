using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] arr1 = input.ToArray();

            char[] arr = { 'a', 'b', 'c',
                'd', 'e', 'f', 'g',
                'h', 'i', 'j', 'k',
                'l', 'm', 'n', 'o',
                'p', 'q', 'r', 's',
                't', 'u', 'v', 'w',
                'x', 'y', 'z' };

            for (int i = 0; i < arr1.Length; i++)
            {

                for (int c = 0; c < arr.Length; c++)
                {
                    if (arr1[i] == arr[c])
                    {
                        Console.WriteLine(arr[c] + " -> " + c);
                    }

                }

            }


        }
    }
}
