using System;
using System.Collections.Generic;
using System.Linq;

namespace Inferno_III
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> gems = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            gems.Insert(0, 0);
            gems.Add(0);
            List<string> filterValue = new List<string>();
            while (true)
            {
                string[] commands = Console.ReadLine().Split(';');
                
                if (commands[0] == "Forge") break;
                if (commands[0] == "Exclude")
                {
                    filterValue.Add(commands[1] + ":" + commands[2]);
                }
                else if (commands[0] == "Reverse")
                {
                    filterValue.Remove(commands[1] + ":" + commands[2]);
                }                              
            }
            Predicate<int> parser;
            List<int> gemstoremove = new List<int>();
            foreach (var item in filterValue)
            {
                var splitter = item.Split(':');

                parser = ReturnQualityGems(splitter[0], int.Parse(splitter[1]), gems);
                for (int i = 1; i < gems.Count - 1; i++)
                {
                    if (parser(i))
                    {
                        gemstoremove.Add(i);
                    }
                }

            }
            
            for (int i = 1; i < gems.Count - 1; i++)
            {
                if (!gemstoremove.Contains(i))
                {
                    Console.Write(gems[i] + " ");
                }
            }
            
        }
        public static Predicate<int> ReturnQualityGems (string condition, int value, List<int> currentList)
        {
          
                if (condition == "Sum Left")
                {                   
                        return i => currentList[i] + currentList[i - 1] == value;                   
                }
                else if (condition == "Sum Right")
                {                    
                        return i => currentList[i] + currentList[i + 1] == value;                  
                }
                else if (condition == "Sum Left Right")
                {                   
                        return i => currentList[i] + currentList[i + 1] + currentList[i - 1] == value;                   
                }                                          
            return null;
        }
    }
}
