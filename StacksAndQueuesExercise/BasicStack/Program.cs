using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStack
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] com = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var stack = new Stack<int>();

            var read = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < com[0]; i++)
            {
                stack.Push(read[i]);
            }
            for (int i = 0; i < com[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(com[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if(stack.Count != 0)
                Console.WriteLine(stack.Min());
                else
                    Console.WriteLine("0");
            }
        }
    }
}
