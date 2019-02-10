using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurances
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Input = Console.ReadLine().ToLower().Split(' ').ToList();

            Dictionary<string, int> Counter = new Dictionary<string, int>();

            for (int i = 0; i < Input.Count(); i++)
            {
                if (Counter.ContainsKey(Input[i]))
                {
                    Counter[Input[i]] += 1;
                }
                else
                {
                    Counter.Add(Input[i], 1);
                }
            }
            Console.WriteLine(string.Join(" ", Counter.Keys.Where(x => Counter[x] % 2 != 0).ToList()));
        }
    }
}
