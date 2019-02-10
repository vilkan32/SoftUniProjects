using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var stack = new Stack<long>();
            stack.Push(1);
            stack.Push(0);
            int counter = 0;
            while (true)
            {
                long topElement = stack.Pop();
                long botElement = stack.Pop();
                if (n == 0)
                {
                    Console.WriteLine(0);
                    break;
                }
               
                stack.Push(topElement + botElement);
                stack.Push(botElement);
                counter++;
                 if (n == counter)
                {
                    Console.WriteLine(stack.ElementAt(0));
                    break;
                }
            }

        }
    }
}
