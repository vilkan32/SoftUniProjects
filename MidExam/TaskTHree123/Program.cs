using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTHree123
{
    class Program
    {
        static void Main(string[] args)

        {
            List<string> input = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(" - ").ToArray();
                if (commands[0] == "Retire!")
                {
                    break;
                }
                if (!input.Contains(commands[1]) && commands[0] == "Start")
                {
                    input.Add(commands[1]);
                }
                if (commands[0] == "Complete" && input.Contains(commands[1]))
                {
                    input.Remove(commands[1]);
                }
                if (commands[0] == "Side Quest")
                {
                    string[] split = commands[1].Split(":").ToArray();

                    if (input.Contains(split[0]) && !input.Contains(split[1]))
                    {
                        int index = input.IndexOf(split[0]);
                        input.Insert(index + 1, split[1]);
                    }
                }
                if (commands[0] == "Renew")
                {
                    if (input.Contains(commands[1]))
                    {
                        int index = input.IndexOf(commands[1]);
                        string element = input[index];
                        input.RemoveAt(index);
                        input.Add(element);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
