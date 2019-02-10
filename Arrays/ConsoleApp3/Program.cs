using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool notFound = true;
            for (int i = 0; i < arr.Length; i++)
            {
                
                for (int r = i +1; r < arr.Length; r++)
                {
                    int sum = arr[i] + arr[r];
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{arr[i]} + {arr[r]} == {sum}");
                        if (notFound)
                            notFound = false;

                    }
                }
            }
            if (notFound)
                Console.WriteLine("No");

        }
    }
}
