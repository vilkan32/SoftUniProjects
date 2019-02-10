using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            string n = Console.ReadLine();
            if (n == "face")
            {
                Console.WriteLine(GetFaceDiagonal(number));
            }

            else if (n == "space")
            {
                Console.WriteLine(GetSpaceDiagonal(number));
            }
            else if (n == "volume")
            {
                Console.WriteLine(GetVolume(number));
            }
            else if (n == "area")
            {
                Console.WriteLine(GetArea(number));
            }

        }




        static double GetFaceDiagonal(double n)

        {

            double output = Math.Sqrt(2 * n * n);
            return Math.Round(output, 2);
        
        }

        static double GetSpaceDiagonal(double n)

        {
            double output = Math.Sqrt(3 * n * n);
            return Math.Round(output, 2);

        }
        static double GetVolume(double n)

        {
            double output = Math.Pow(n,3);
            return Math.Round(output, 2);

        }
        static double GetArea(double n)

        {
            double output = Math.Pow(n, 2) * 6;
            return Math.Round(output, 2);

        }
    }
}
