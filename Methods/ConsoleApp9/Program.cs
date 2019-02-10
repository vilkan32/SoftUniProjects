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




            int read = int.Parse(Console.ReadLine());

            int output = Getmultiply(read);
            Console.WriteLine(output);
        }


        private static int GetOdd(int n)
        {

            int sum = 0;

            while (Math.Abs(n) > 0)
            {
                int lastdigit = n % 10;
                if (lastdigit % 2 != 0)
                {
                    sum += Math.Abs(lastdigit);
                }
                n /= 10;

            }
            return sum;
        }

        private static int GetEven(int n)
        {
            int sum = 0;
            while (Math.Abs(n) > 0)
            {
                int lastdigit = n % 10;
                if (lastdigit % 2 == 0)
                {
                    sum += Math.Abs(lastdigit);
                }
                n /= 10;
            }
            return sum;
        }

        private static int Getmultiply(int n)

        {
            int sumeven = GetEven(n);
            int sumodd = GetOdd(n);
            return Math.Abs(sumeven * sumodd);

        }
    }
}
