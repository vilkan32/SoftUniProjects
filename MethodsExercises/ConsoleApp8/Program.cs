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

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double x1 = double.Parse(Console.ReadLine());

            double y1 = double.Parse(Console.ReadLine());

            GetTheClosestPoint(x, y, x1, y1);
        }

        static void GetTheClosestPoint(double x, double y, double x1, double y1)

        {
            double GetMaxOfX = Math.Max(Math.Abs(x), Math.Abs(x1));

            double GetMinOfX = Math.Min(Math.Abs(x), Math.Abs(x1));
            double GetMaxOfY = Math.Max(Math.Abs(y), Math.Abs(y1));
            double GetMinOfY = Math.Min(Math.Abs(y), Math.Abs(y1));

            
            
            bool xbiggerthenx1 = true;
            bool ybiggertheny1 = true;


            double razlikax = GetMaxOfX - GetMinOfX;
            double razlikay = GetMaxOfY - GetMinOfY;
            double outputininumber = Math.Abs(razlikax) - Math.Abs(razlikay);
            if (Math.Abs(x) >= Math.Abs(x1))
            {
                
               xbiggerthenx1 = true;
            }
            else if (Math.Abs(x) < Math.Abs(x1))
            {
                xbiggerthenx1 = false;
            }
            if (Math.Abs(y) >= Math.Abs(y1))
            {

                ybiggertheny1 = true;
            }
            else if (Math.Abs(y) < Math.Abs(y1))
            {
                ybiggertheny1 = false;
            }

            // ako x e po golqm ot y1 trqbva da se vidi razlikata 
            if (xbiggerthenx1 && ybiggertheny1)
            {
                Console.WriteLine("({0}, {1})", x1,y1);
            }
            else if (!ybiggertheny1 && !xbiggerthenx1)
            {
                Console.WriteLine("({0}, {1})", x, y);
            }
            else if (ybiggertheny1 && !xbiggerthenx1)
            {
                if (Math.Abs(razlikax) > Math.Abs(razlikay))
                {
                    Console.WriteLine("({0}, {1})", x, y);
                }
            }
            else if (!ybiggertheny1 && xbiggerthenx1)
            {
                if (Math.Abs(razlikax) < Math.Abs(razlikay))
                {
                    Console.WriteLine("({0}, {1})", x1, y1);
                }
            }
            else
            {
                Console.WriteLine("({0}, {1})", x, y);
            }
            
            
                
           
        }
    }
}
