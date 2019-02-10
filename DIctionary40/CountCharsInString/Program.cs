using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Input = Console.ReadLine().Split(' ').ToList();

            Dictionary<char, int> NumberOCharacters = new Dictionary<char, int>();

            for (int i = 0; i < Input.Count(); i++)
            {
                string result = Input[i];

                foreach (var item in result)
                {
                    if (NumberOCharacters.ContainsKey(item))
                    {
                        NumberOCharacters[item] += 1;
                    }
                    else
                    {
                        NumberOCharacters.Add(item, 1);
                    }
                }
            }

            foreach (var item in NumberOCharacters)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
