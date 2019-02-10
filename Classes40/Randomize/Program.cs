using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize
{
    class Program
    {
        static void Main(string[] args)
        {
          

            string[] input = Console.ReadLine().Split(' ').ToArray();


            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {

                int randomposition = rnd.Next(input.Length);

                string currentword = input[i];

                input[i] = input[randomposition];
                input[randomposition] = currentword;

            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }


        }
    }
}
