using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimleStackCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ').ToArray();

            var stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int second = int.Parse(stack.Pop());

                if (operation == "-")
                {
                    stack.Push((first - second).ToString());

                }
                else if (operation == "+")
                {
                    stack.Push((first + second).ToString());
                }
            }
            Console.WriteLine(stack.Peek());
        }
    }
}
