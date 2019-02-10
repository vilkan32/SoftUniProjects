using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotatoe
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = Console.ReadLine().Split(' ');

            var number = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(children);

            while (queue.Count() != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());

                }
                Console.WriteLine("Removed {0}", queue.Dequeue());

            }
            Console.WriteLine("Last is {0}", queue.Dequeue());




        }
    }
}
