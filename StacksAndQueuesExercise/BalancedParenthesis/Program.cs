using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            if (input.Length % 2 == 1)
            {
                Console.WriteLine("NO");
                return;
            }
            var stack = new Stack<char>();
           
            bool cango = true;

            foreach (var item in input)
            {
                if (item == '{' || item=='[' || item == '(')
                {
                    stack.Push(item);
                }
                else
                {
                    if (item == '}' || item == ']' || item == ')' && stack.Count > 0)
                    {
                        if ((stack.Peek() == '{' && item == '}') || (stack.Peek() == '[' && item == ']') || (stack.Peek() == '(' && item == ')'))
                        {
                            stack.Pop();
                        }
                        else
                        {
                            cango = false;
                            Console.WriteLine("NO");
                            break;
                        }
                    }
                    else
                    {
                        cango = false;
                        Console.WriteLine("NO");
                        break;
                    }
                }
            }
            if (cango)
            {
                Console.WriteLine("YES");
            }


        }
    }
}
