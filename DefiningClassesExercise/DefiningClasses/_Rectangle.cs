using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class _Rectangle
    {

        private string id;

        private double width;

        private double height;

        private double x;

        private double y;


        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }


        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public _Rectangle(string id, double width, double height, double x, double y)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.X = x;
            this.Y = y;
        }

        public static void ReturnIntersection(int numberOfIntersection, Queue<_Rectangle> allRectangles)
        {
            while (numberOfIntersection > 0)
            {
                var pair = Console.ReadLine().Split();
                var firstRect = allRectangles.Where(r => r.Id == pair[0]).FirstOrDefault();
                var secondRect = allRectangles.Where(r => r.Id == pair[1]).FirstOrDefault();
               
                Console.WriteLine(firstRect.IsThereIntersection(secondRect) ? "true" : "false");

                numberOfIntersection--;
            }
        }

        public bool IsThereIntersection(_Rectangle rectangle)
        {
            return rectangle.X + rectangle.Width >= this.X &&
                rectangle.X <= this.X + this.Width &&
                rectangle.Y >= this.Y - this.Height &&
                rectangle.Y - rectangle.Height <= this.Y;
        }


    }
}
