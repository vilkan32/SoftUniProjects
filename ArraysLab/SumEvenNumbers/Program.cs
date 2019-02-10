using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Input = Console.ReadLine().Split(' ').Select(int.Parse).Where(a => a%2==0).ToArray();


            if (Input.Length == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(Input.Sum());
            }

        }
    }
}
