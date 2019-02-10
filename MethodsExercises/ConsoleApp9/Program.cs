using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
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
            PringLongerLine(x, y, x1, y1, x2, y2, x3, y3);
        }

        static bool Closerpoint(double x, double y, double x1, double y1)

        {
            double cnavtora1 = (x * x) + (y * y);

            double cnavtora2 = (x1 * x1) + (y1 * y1);

            bool isfirstcloser = true;
            if (Math.Sqrt((double)cnavtora1) <= Math.Sqrt((double)cnavtora2))
            {
                isfirstcloser = true;

            }
            else if (Math.Sqrt((double)cnavtora1) > Math.Sqrt((double)cnavtora2))
            {

                isfirstcloser = false;
            }

            return isfirstcloser;
        }

        static void PringLongerLine(double x, double y, double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double line1 = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2));
            double line2 = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));

            if (line1 >= line2)
            {
                bool isfirstcloser = Closerpoint(x, y, x1, y1);

                if (isfirstcloser)
                {
                    Console.WriteLine($"({x}, {y})({x1}, {y1})");
                }
                else
                {
                    Console.WriteLine($"({x1}, {y1})({x}, {y})");
                }
            }
            else
            {
                bool isfirstcloser = Closerpoint(x2, y2, x3, y3);

                if (isfirstcloser)
                {
                    Console.WriteLine($"({x2}, {y2})({x3}, {y3})");
                }
                else
                {
                    Console.WriteLine($"({x3}, {y3})({x2}, {y2})");
                }
            }
        }
    }
}
