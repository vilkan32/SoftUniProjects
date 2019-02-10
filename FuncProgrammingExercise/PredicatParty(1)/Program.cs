using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicatParty_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Party = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Party!")
                {
                    break;
                }
                if (command[0] == "Remove")
                {
                    if (command[1] == "StartsWith")
                    {
                        Party.RemoveAll(x => x.StartsWith(command[2]));
                    }
                    else if (command[1] == "EndsWith")
                    {
                        Party.RemoveAll(x => x.EndsWith(command[2]));
                    }
                    else if (command[1] == "Length")
                    {
                        Party.RemoveAll(x => x.Length == int.Parse(command[2]));

                    }
                }
                else if (command[0] == "Double")
                {
                    List<string> peopleToDouble = new List<string>();

                    if (command[1] == "StartsWith")
                    {
                        peopleToDouble = Party.Where(x => x.StartsWith(command[2])).ToList();
                    }
                    else if (command[1] == "EndsWith")
                    {
                        peopleToDouble = Party.Where(x => x.EndsWith(command[2])).ToList();
                    }
                    else if (command[1] == "Length")
                    {
                        peopleToDouble = Party.Where(x => x.Length == int.Parse(command[2])).ToList();
                    }  
                    
                        foreach (var set in peopleToDouble)
                        {                           
                           int index = Party.IndexOf(set);
                           Party.Insert(index + 1, set);                            
                        }
                    
                }
            }
            if (Party.Any())
            {
                Console.WriteLine(string.Join(", ", Party) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            
        }
    }
}
