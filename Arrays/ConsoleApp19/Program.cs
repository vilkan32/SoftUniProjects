using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int counter = 0;
            int excounter = 0;
            int number = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int c = 0; c < arr.Length; c++)
                {
                    if (arr[i] == arr[c])
                    {
                        counter++;
                    }
                }

                if (excounter < counter)
                {
                    excounter = counter;

                    counter = 0;
                    number = arr[i];
                }
                else
                {
                    counter = 0;
                }
            }
            Console.WriteLine(number);
        }
    }
}
