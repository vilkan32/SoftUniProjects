using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Point first = new Point();
            Point second = new Point();

            if (ReturnResult(first, second))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        static bool ReturnResult(Point one, Point two)
        {
            double calc = Math.Abs(one.X - two.X);
            double calc1 = Math.Abs(one.Y - two.Y);

            double Distance = calc * calc + calc1 * calc1;
            Distance = Math.Sqrt(Distance);

            if (Distance <= one.Radius + two.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }


    class Point
    {
        double[] Input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        public double X { get { return this.Input[0]; } }

        public double Y { get { return this.Input[1]; } }
        public double Radius { get { return this.Input[2]; } }
    }

}
