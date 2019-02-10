using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int a = int.Parse(Console.ReadLine());
            int counter = 0;
            int index = 0;


            while (index < arr.Length)
            {
                for (int c = 0; c < arr.Length; c++)
                {

                    if (arr[index] - arr[c] == Math.Abs(a))
                    {
                        counter++;
                    }
                   

                }
                index++;
            }
            
            


            Console.WriteLine(counter);





        }
    }
}
