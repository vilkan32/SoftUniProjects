using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {



            List<string> Input = Console.ReadLine().ToLower().Split(' ').ToList();


            Dictionary<string, int> SingleNumbersAndOccurances = new Dictionary<string, int>();

            foreach (var input in Input)
            {

                if (!SingleNumbersAndOccurances.ContainsKey(input))
                {
                    SingleNumbersAndOccurances.Add(input, 1);
                }
                else
                {
                    SingleNumbersAndOccurances[input]++;
                }


            }


            List<string> output = new List<string>();
            foreach (KeyValuePair<string, int> key in SingleNumbersAndOccurances)
            {
                if (key.Value % 2 != 0)
                {
                    output.Add(key.Key);
                }
            }



            Console.WriteLine(string.Join(", ", output));

        }
    }
}
