using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstPairs = Console.ReadLine().Split(@" | ", StringSplitOptions.RemoveEmptyEntries);
            SortedDictionary<string, List<string>> WordsDefinitions = new SortedDictionary<string, List<string>>();

            for (int i = 0; i < firstPairs.Length; i++)
            {
                string[] secondPairs = firstPairs[i].Split(": ", StringSplitOptions.RemoveEmptyEntries);

                if (!WordsDefinitions.ContainsKey(secondPairs[0]))
                {
                    WordsDefinitions.Add(secondPairs[0], new List<string>());
                    WordsDefinitions[secondPairs[0]].Add(secondPairs[1]);
                }
                else
                {
                    WordsDefinitions[secondPairs[0]].Add(secondPairs[1]);
                }
            }

            string[] secondInput = Console.ReadLine().Split(@" | ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in secondInput)
            {
                if (WordsDefinitions.ContainsKey(item))
                {
                    Console.WriteLine(item);
                    foreach (var set in WordsDefinitions[item].OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine(" -" + set);
                    }
                }
            }

            string final = Console.ReadLine();

            if (final == "End")
            {

            }
            else if (final == "List")
            {
                foreach (var item in WordsDefinitions.Keys)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
