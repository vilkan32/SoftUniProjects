using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int[] numberstoreverese = new int[a];

            for (int i = 0; i < numberstoreverese.Length; i++)
            {
                numberstoreverese[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numberstoreverese);
            Console.WriteLine(string.Join(" ", numberstoreverese));
        }
    }
}
