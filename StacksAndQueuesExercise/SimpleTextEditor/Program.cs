using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string current = string.Empty;

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                string sayz = command[0];
                if (sayz == "1")
                {
                    string current1 = command[1];
                    stack.Push(current);
                    current += current1;

                }
                else if (sayz == "2")
                {
                    stack.Push(current);
                    current = current.Substring(0, current.Length - int.Parse(command[1]));
                }
                else if (sayz == "3")
                {
                    Console.WriteLine(current[int.Parse(command[1]) - 1]);
                }
                else if (sayz == "4")
                {
                    current = stack.Pop();
                }

            }


        }
    }
}