using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int numberoftimes = int.Parse(Console.ReadLine());

            string result = "";

            for (int i = 1; i <= numberoftimes; i++)
            {
                result += input;
            }
            Console.WriteLine(result);
        }
    }
}
