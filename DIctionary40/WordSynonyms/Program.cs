using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> WordSynonym = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string Key = Console.ReadLine();
                string Value = Console.ReadLine();

                if (WordSynonym.ContainsKey(Key))
                {
                    WordSynonym[Key].Add(Value);
                }
                else
                {
                    WordSynonym.Add(Key, new List<string>());
                    WordSynonym[Key].Add(Value);
                }
            }
            foreach (var item in WordSynonym)
            {
                Console.WriteLine(item.Key + " - " + string.Join(", ", item.Value));
            }
        }
    }
}
