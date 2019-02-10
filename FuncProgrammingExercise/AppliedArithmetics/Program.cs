using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                    break;

                if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", input));
                }
                else
                {
                    input = input.Select(ExecutionOfCommand(command)).ToList();
                }

               

            }
            

        }

        public static Func<int, int> ExecutionOfCommand(string command)
        {
            if (command == "add")
            {
                return x => x + 1;
            }
          
            else if (command == "subtract")
            {
                return x => x - 1;
            }
            else if (command == "multiply")
            {
                return x => x * 2;
            }
            else
            {
                return null;
            }

            
        }

    }
}
