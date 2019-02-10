using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle first = new Rectangle();
            Rectangle second = new Rectangle();
            if (Inside(first,second))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not Inside");
            }
        }

        static bool Inside(Rectangle r1, Rectangle r2)
        {
            bool left1 = false;
            bool right1 = false;
            bool top1 = false;
            bool bottom1 = false;
            bool output = false;
            if (r1.left>= r2.left)
                left1 = true;
            if (r1.right <= r2.right)
                right1 = true;
            if (r1.top <= r2.top)
                top1 = true;
            if (r1.bottom <= r2.bottom)
                bottom1 = true;
            if (left1 && right1 && top1 && bottom1)
            {
                output = true;
            }

            return output;
        }
    }

    class Rectangle
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        public int left { get {return this.input[0]; } }
        public int top { get { return this.input[1]; } }
        public int width { get { return this.input[2]; } }
        public int height { get { return this.input[3]; } }
        public int right { get { return this.input[0] + this.input[2]; } }
        public int bottom { get { return this.input[1] + input[3]; } }
    }

}
