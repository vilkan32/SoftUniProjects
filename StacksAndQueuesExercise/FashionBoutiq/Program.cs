using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionBoutiq
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = Console.ReadLine().Split(' ').Select(int.Parse);

            Stack<int> Clothes = new Stack<int>(clothes.Reverse());

            int capacity = int.Parse(Console.ReadLine());
            int pushin = capacity;
            int counter = 1;
            while (Clothes.Any())
            {
                if (capacity == 0)
                {
                    break;
                }
                if (pushin - Clothes.Peek() >= 0)
                {                    
                    pushin-= Clothes.Pop();
                }
                else
                {
                    pushin = capacity;
                    counter++;
                }

            }

                Console.WriteLine(counter);            
        }
    }
}
