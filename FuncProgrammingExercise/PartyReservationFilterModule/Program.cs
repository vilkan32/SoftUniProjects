using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, List<string>> filterValue = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] commands = Console.ReadLine().Split(';').ToArray();

                if (commands[0] == "Print")
                {
                    break;
                }

                if (commands[0] == "Add filter")
                {

                    if (!filterValue.ContainsKey(commands[1]))
                    {
                        filterValue.Add(commands[1], new List<string>());
                        filterValue[commands[1]].Add(commands[2]);
                    }
                    else
                    {
                        filterValue[commands[1]].Add(commands[2]);
                    }

                }
                else if (commands[0] == "Remove filter")
                {
                    filterValue[commands[1]].Remove(commands[2]);
                }
                

            }
            Console.WriteLine(string.Join(" ", ReturnFiltered(filterValue, input)));
        }
        public static List<string> ReturnFiltered(Dictionary<string, List<string>> filters, List<string> inputList)
        {
            // Starts with", "Ends with", "Length" and "Contains
            
            foreach (var item in filters)
            {
                if (item.Key == "Starts with")
                {
                    if (item.Value.Any())
                    {
                        foreach (var set in item.Value)
                        {
                            inputList = inputList.Where(x => !x.StartsWith(set)).ToList();
                        }
                    }
                }
                else if (item.Key == "Ends with")
                {
                    if (item.Value.Any())
                    {
                        foreach (var set in item.Value)
                        {
                            inputList = inputList.Where(x => !x.EndsWith(set)).ToList();
                        }
                    }
                }
                else if (item.Key == "Length")
                {
                    if (item.Value.Any())
                    {
                        foreach (var set in item.Value)
                        {
                            inputList = inputList.Where(x => x.Length != int.Parse(set)).ToList();
                        }
                    }
                }
                else if (item.Key == "Contains")
                {
                    if (item.Value.Any())
                    {
                        foreach (var set in item.Value)
                        {
                            inputList = inputList.Where(x => !x.Contains(set)).ToList();
                        }
                    }
                }
            }
            return inputList;

        }
    }
}
