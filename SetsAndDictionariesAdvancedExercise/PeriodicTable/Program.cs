using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> Table = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                foreach (var item in input)
                {
                    Table.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", Table.OrderBy(x => x)));
        }
    }
}
