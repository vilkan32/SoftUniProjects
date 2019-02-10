using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            
List<string> commands = Console.ReadLine().Split(' ').ToList();
            while (commands[0] != "print")
            {
                if (commands[0] == "add")
                {
                    int index = Convert.ToInt32(commands[1]);
                    int element = Convert.ToInt32(commands[2]);
                    Input.Insert(index, element);
                }
                else if (commands[0] == "addMany")
                {
                    int index = Convert.ToInt32(commands[1]);
                    int numberofelements = commands.Count - 2;
                    for (int i = 2; i < commands.Count; i++)
                    {
                        int element = Convert.ToInt32(commands[i]);
                        Input.Insert(index, element);
                        index++;
                    }
                }
                else if (commands[0] == "contains")
                {
                    int element = Convert.ToInt32(commands[1]);
                    try
                    {
                     int theindex = Input.IndexOf(element);
                        Console.WriteLine(theindex);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("-1");
                    }

                }
                else if (commands[0] == "remove")
                {
                    int index = Convert.ToInt32(commands[1]);
                    Input.RemoveAt(index);
                }
                else if (commands[0] == "shift")
                {
                    int positions = Convert.ToInt32(commands[1]);
                    int firstnumber = Input[0];

                    for (int i = 0; i < positions; i++)
                    {
                        Input.RemoveAt(0);
                        Input.Insert(Input.Count, firstnumber);
                        firstnumber = Input[0];
                    }
                   

                }
                else if (commands[0] == "sumPairs")
                {
                    List<int> Output = new List<int>();
                    int b = 1;
                    for (int a = 0; a < Input.Count; a+=2)
                    {

                        try
                        {
                            Output.Add(Input[a] + Input[b]);
                        }
                        catch (Exception)
                        {
                            Output.Add(Input[a]);


                        }
                            b += 2;
                        
                    }
                    Input = Output;
                }
                else
                {
                    break;
                }
                commands = Console.ReadLine().Split(' ').ToList();
            }
            Console.Write("["); Console.Write(string.Join(", ",Input)); Console.Write("]");
            Console.WriteLine();
        }
    }
}
