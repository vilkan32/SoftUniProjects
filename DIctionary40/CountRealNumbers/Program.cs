using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Dictionary<int, int> Numbers = new Dictionary<int, int>();

            for (int i = 0; i < Input.Count(); i++)
            {
                if (Numbers.ContainsKey(Input[i]))
                {
                    Numbers[Input[i]]++;
                }
                else
                {
                    Numbers.Add(Input[i], 1);
                }
            }

            foreach (var item in Numbers.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
