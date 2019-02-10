using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {


            double x = double.Parse(Console.ReadLine());

            double y = double.Parse(Console.ReadLine());

            double x1 = double.Parse(Console.ReadLine());

            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());

            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());

            double y3 = double.Parse(Console.ReadLine());


            double distance = Math.Round(Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2)), 2);
            double distance1 = Math.Round(Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)), 2);
            if (distance > distance1)
            {
                ReturnCloserPoint(x,y,x1,y1);
            }
            else if (distance < distance1)
            {
                ReturnCloserPoint(x2, y2, x3, y3);
            }
            else if (distance == distance1)
            {
                ReturnCloserPoint(x, y, x1, y1);
            }
        }
        public static void ReturnCloserPoint(double x, double y, double x1, double y1)
        {
            double result = Math.Round(Math.Sqrt((x * x) + (y * y)), 1);
            double result1 = Math.Round(Math.Sqrt((x1 * x1) + (y1 * y1)), 1);
           
            if (result < result1)
            {
                Console.WriteLine($"({x}, {y})" + $"({x1}, {y1})");
            }
            else if (result > result1)
            {
                Console.WriteLine($"({x1}, {y1})" + $"({x}, {y})");
            }
            else
            {
                Console.WriteLine($"({x}, {y})" + $"({x1}, {y1})");
            }
        }
    }
}
