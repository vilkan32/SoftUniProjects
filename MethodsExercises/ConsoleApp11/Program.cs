using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "triangle")
            {
                GetTriangleArea();
            }
            else if (figure == "square")
            {
                GetSquareArea();
            }
            else if (figure == "rectangle")
            {
                GetRectangleArea();
            }
            else if (figure == "circle")
            {
                GetCircleArea();
            }

        }

        private static void GetCircleArea()
        {
            double side = double.Parse(Console.ReadLine());


            double formula = Math.Pow(side, 2) * Math.PI ;
            formula = Math.Round(formula, 2);
            Console.WriteLine("{0:f2}", formula);
        }

        private static void GetRectangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double formula = side * height;
            formula = Math.Round(formula, 2);
            Console.WriteLine("{0:f2}", formula);
        }

        private static void GetSquareArea()
        {
            double side = double.Parse(Console.ReadLine());


            double formula = Math.Pow(side, 2);
            formula = Math.Round(formula, 2);
            Console.WriteLine("{0:f2}", formula);
        }

        static void GetTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double formula = 0.5 * side * height;
            formula = Math.Round(formula, 2);
            Console.WriteLine("{0:f2}", formula);

        }
    }
}
