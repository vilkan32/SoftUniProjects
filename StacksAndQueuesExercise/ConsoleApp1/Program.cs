using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(' ').Select(int.Parse);
            Stack<int> Input = new Stack<int>(input);

            while (true)
            {
                
                var Commands = Console.ReadLine().Split(' ');
                Stack<string> commands = new Stack<string>(Commands.Reverse());
                if (commands.Peek().ToLower() == "end")
                {
                    break;
                }
                else if (commands.Peek().ToLower() == "add")
                {
                    commands.Pop();
                    while (commands.Any())
                    {
                        Input.Push(int.Parse(commands.Pop()));
                    }
                }
                else if (commands.Peek().ToLower() == "remove")
                {
                    commands.Pop();
                    int numberstoremove = int.Parse(commands.Pop());

                    if (numberstoremove > Input.Count())
                    {
                        continue;
                    }
                    else
                    {
                        while (true)
                        {
                            Input.Pop();

                            numberstoremove--;
                            if (numberstoremove == 0)
                            {
                                break;
                            }
                        }
                    }

                }

            }

            Console.WriteLine("Sum: "+ Input.Sum());

        }
    }
 
}
