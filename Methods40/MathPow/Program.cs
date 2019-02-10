using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPow
{
    class Program
    {
        static void Main(string[] args)
        {

            double Base = double.Parse(Console.ReadLine());
            int Power = int.Parse(Console.ReadLine());
            double result = Math.Pow(Base, Power);
            Console.WriteLine("{0}",result);
        }
    }
}
