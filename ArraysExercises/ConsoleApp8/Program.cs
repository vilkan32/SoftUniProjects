using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberoflines = int.Parse(Console.ReadLine());
            int[] ListofDigits = new int[numberoflines];

            for (int i = 0; i < numberoflines; i++)
            {
                ListofDigits[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", ListofDigits));
            Console.WriteLine(ListofDigits.Sum());

        }
    }
}
