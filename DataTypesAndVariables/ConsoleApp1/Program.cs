using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int numasinteger;
            double numasdouble;
            char character;
          
            bool boolean;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                if (int.TryParse(input, out numasinteger))
                {
                    Console.WriteLine("{0} is integer type",input);
                }
                else if (double.TryParse(input, out numasdouble))
                {
                    Console.WriteLine("{0} is floating point type",input);
                }
                else if (char.TryParse(input, out character))
                {
                    Console.WriteLine("{0} is character type", input);
                }
                else if (bool.TryParse(input, out boolean))
                {
                    Console.WriteLine("{0} is boolean type", input);
                }
                else
                {
                    Console.WriteLine("{0} is string type", input);
                }

            }
        }
    }
}
