using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Point p1 = new Point();

            Point p2 = new Point();

            double a = Returnpoint(p1, p2);

            Console.WriteLine();
            */

            int a = int.Parse(Console.ReadLine());
            Point[] multiplepoints = new Point[a];
            for (int i = 0; i < a; i++)
            {

                multiplepoints[i] = new Point();
            }
            List<double> Distance = new List<double>();
            Distance = DistanceToList(multiplepoints).ToList();
            List<double> PositionofX = XtoList(multiplepoints).ToList();
            List<double> PositionOFY = YtoList(multiplepoints).ToList();

            double mindistance = 0;
            mindistance = Distance.Min();
            int index = Distance.IndexOf(mindistance);

            Console.WriteLine("{0:f3}", Math.Round(mindistance, 3));
            Console.WriteLine("({0}, {1})", PositionofX[index * 2], PositionofX[index * 2 + 1]);
            Console.WriteLine("({0}, {1})", PositionOFY[index * 2], PositionOFY[index * 2 + 1]);
        }

        public static double ReturnpointDistance(Point first, Point second)
        {
            double A = Math.Abs(first.X - second.X);

            double B = Math.Abs(first.Y - second.Y);

            double C = A * A + B * B;

            C = Math.Sqrt(C);
            return C;
        }
        public static double[] DistanceToList(Point[] somepoint)
        {
            List<double> Distance = new List<double>();
            int indexer = 1;
            for (int i = 0; i < somepoint.Length - 1; i++)
            {

                for (int x = indexer; x < somepoint.Length; x++)
                {

                    Distance.Add(ReturnpointDistance(somepoint[i], somepoint[x]));

                }
                indexer++;

            }

            return Distance.ToArray();
        }

        public static double[] XtoList(Point[] somepoint)
        {
            List<double> X = new List<double>();
            int indexer = 1;
            for (int i = 0; i < somepoint.Length - 1; i++)
            {

                for (int x = indexer; x < somepoint.Length; x++)
                {

                    X.Add(somepoint[i].X);
                    X.Add(somepoint[i].Y);
                }

                indexer++;
            }

            return X.ToArray();
        }


        public static double[] YtoList(Point[] somepoint)
        {
            List<double> X = new List<double>();
            int indexer = 1;
            for (int i = 0; i < somepoint.Length - 1; i++)
            {

                for (int x = indexer; x < somepoint.Length; x++)
                {
                    X.Add(somepoint[x].X);
                    X.Add(somepoint[x].Y);
                }

                indexer++;
            }

            return X.ToArray();
        }

    }






       class Point
            {

        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        public int X
        {
            get { return this.input[0]; }
            set { this.X = input[0]; }
        }

        public int Y
         {
            get { return this.input[1]; }
            set { this.Y = input[1]; }
         }



        }

}

