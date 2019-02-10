using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] input = Console.ReadLine().Split('-').Select(int.Parse).ToArray();

       
            DateTime input1 = new DateTime(input[2],input[1],input[0]);

            Console.WriteLine(input1.DayOfWeek);
            
             */

            /*

            string input = Console.ReadLine();

            string format = "d-M-yyyy";

            DateTime output = DateTime.ParseExact(input, format, System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine(output.DayOfWeek);
            */
            /*
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
            */







        }
    }
}
