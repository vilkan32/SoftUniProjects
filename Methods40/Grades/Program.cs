using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            double input = double.Parse(Console.ReadLine(), NumberStyles.Any);
            GradesAsWord(input);
        }

        static void GradesAsWord(double input)
        {
            if (input >= 2.00 && input <=2.99)
            {
                //Fail
                Console.WriteLine("Fail");
            }
            else if (input >= 3.00 && input <=3.49 )
            {
                //Poor
                Console.WriteLine("Poor");
            }
            else if (input >= 3.50 && input <= 4.49)
            {
                // Good
                Console.WriteLine("Good");
            }
            else if (input >= 4.50 && input <= 5.49)
            {
                // Verry Good
                Console.WriteLine("Very good");
            }
            else if (input >= 5.50 && input <= 6.00)
            {
                // Excellent
                Console.WriteLine("Excellent");
            }
        }
    }
}
