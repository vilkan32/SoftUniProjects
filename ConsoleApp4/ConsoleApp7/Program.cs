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
            var name = Console.ReadLine();

            double gramaj = double.Parse(Console.ReadLine());

            double energy = double.Parse(Console.ReadLine());

            double sugar = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}ml {1}:", gramaj, name);
            Console.WriteLine("{0}kcal, {1}g sugars ", gramaj/100 * energy, gramaj/ 100 * sugar);




        }
    }
}
