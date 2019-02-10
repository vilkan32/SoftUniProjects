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
            List<double> Input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            

            List<double> Result = new List<double>();

            foreach (var item in Input)
            {
                double result = Math.Sqrt(item);

                if (result == (int)result)
                {
                    Result.Add(item);
                }



            }

            Result.Sort();

            Result.Reverse();

            Console.WriteLine(string.Join(" ", Result));



        }
    }
}
