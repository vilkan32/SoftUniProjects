using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] com = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var queue = new Queue<int>();

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < com[0]; i++)
            {
                queue.Enqueue(input[i]);
            }
            for (int i = 0; i < com[1]; i++)
            {
                if (queue.Count != 0)
                {
                    queue.Dequeue();
                }
            }

            if (queue.Contains(com[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count != 0)
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
