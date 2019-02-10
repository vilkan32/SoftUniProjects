using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicatePary
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Party = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "Party!")
                {
                    break;
                }

                Party = ReturnCommand(command, Party);
               
            }

            if (Party.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.Write(string.Join(", ", Party));
                Console.WriteLine("are going to the party!");
            }

        }

        public static List<string> ReturnCommand(string[] command, List<string> current)
        {
           
            if (command[0] == "Double")
            {

                if (command[1] == "StartsWith")
                {
                    List<int> result = new List<int>();
                    result = current.Select( (x, i) => { x.StartsWith(command[2]); return i; } ).ToList();
                    for (int i = 0; i < result.Count(); i++)
                    {
                        current.Insert(result[i], current[result[i]]);
                    }
                    return current;
                }
                else if (command[1] == "EndsWith")
                {
                    List<int> result = new List<int>();
                    result = current.Select((x, i) => { x.EndsWith(command[2]); return i; }).ToList();
                    for (int i = 0; i < result.Count(); i++)
                    {
                        current.Insert(result[i], current[result[i]]);
                    }
                    return current;
                }
                else
                {

                    List<int> result = new List<int>();

                    for (int i = 0; i < current.Count; i++)
                    {
                        if (current[i].Length == int.Parse(command[2]))
                        {
                            result.Add(i);
                        }
                    }

                    for (int i = 0; i < result.Count(); i++)
                    {
                        current.Insert(result[i], current[result[i]]);
                    }
                    return current;
                }
            }
            else if (command[0] == "Remove")
            {
                if (command[1] == "StartsWith")
                {
                    List<int> result = new List<int>(); // indexi za premahvane 
                    result = current.Select((x, i) => { x.StartsWith(command[2]); return i; }).ToList();
                    List<string> Result = new List<string>();
                    for (int i = 0; i < current.Count; i++)
                    {
                        for (int c = 0; c < result.Count; c++)
                        {
                            if (i != result[c])
                            {
                                Result.Add(current[i]);
                            }
                        }
                    }
                    
                    return Result;
                }
                else if (command[1] == "EndsWith")
                {
                    List<int> result = new List<int>(); // indexi za premahvane 
                    result = current.Select((x, i) => { x.EndsWith(command[2]); return i; }).ToList();
                    List<string> Result = new List<string>();
                    for (int i = 0; i < current.Count; i++)
                    {
                        for (int c = 0; c < result.Count; c++)
                        {
                            if (i != result[c])
                            {
                                Result.Add(current[i]);
                            }
                        }
                    }

                    return Result;
                }
                else
                {

                    List<int> result = new List<int>();

                    for (int i = 0; i < current.Count; i++)
                    {
                        if (current[i].Length == int.Parse(command[2]))
                        {
                            result.Add(i);
                        }
                    }

                    for (int i = 0; i < result.Count(); i++)
                    {
                        current.RemoveAt(result[i]);
                    }
                    return current;
                }

            }

            return null;
        }
    }
}
