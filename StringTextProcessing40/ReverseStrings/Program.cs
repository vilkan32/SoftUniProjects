using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var reversed = input.ToList();
                reversed.Reverse();
                Console.WriteLine("{0} = {1}",input, string.Join("", reversed));
            }
        }
    }
}
