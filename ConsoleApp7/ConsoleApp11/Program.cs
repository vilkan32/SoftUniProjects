using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            List<int> Output = new List<int>();


            List<string> Command = Console.ReadLine().Split(' ').ToList();

            while (Command[0] != "Even" && Command[0] != "Odd")
            {
                 

                if (Command[0] == "Delete")
                {
                    int commandfordelete = int.Parse(Command[1]);

                    for (int i = 0; i < Input.Count; i++)
                    {
                        if (Input.Remove(commandfordelete))
                        {
                            Input.Remove(commandfordelete);
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                }
                else if (Command[0] == "Insert")
                {
                    int commandforinsert1 = int.Parse(Command[1]);
                    int commandforinsert2 = int.Parse(Command[2]);
                    Input.Insert(commandforinsert2, commandforinsert1);
                }



                Command = Console.ReadLine().Split(' ').ToList();


            }

            if (Command[0] == "Odd")
            {
                foreach (var item in Input)
                {
                    if (item % 2 != 0)
                    {
                        Output.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in Input)
                {
                    if (item % 2 == 0)
                    {
                        Output.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", Output));

        }
    }
}
