using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToList();

            int startTaking = 0;
            int stopTaking = 0;

            if (input.Count() % 2 == 0)
            {
                startTaking = input.Count() / 2 - 1;
                stopTaking = startTaking + 1;
                Console.Write(input[startTaking]);
                Console.Write(input[stopTaking]);
                Console.WriteLine();
            }
            else if (input.Count() % 2 != 0)
            {
                startTaking = input.Count() / 2 ;
                Console.Write(input[startTaking]);
                Console.WriteLine();
            }
          

        }
    }
}
