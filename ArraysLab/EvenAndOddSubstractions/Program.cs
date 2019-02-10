using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenAndOddSubstractions
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] Even = Input.Where(a => a % 2 == 0).ToArray();

            int[] Odd = Input.Where(a => a % 2 != 0).ToArray();

            if (Even.Length == 0)
            {
                Even = new int[1] { 0 };
            }
            else if (Odd.Length == 0)
            {
                Odd = new int[1] { 0 };
            }

            Console.WriteLine(Even.Sum() - Odd.Sum());
        }
    }
}
