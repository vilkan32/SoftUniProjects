using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            string manipulation = Console.ReadLine();

            if (manipulation == "int")
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a * 2);

            }
            else if (manipulation == "real")
            {

                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", a * 1.5);

            }
            else if (manipulation == "string")
            {
                string a = Console.ReadLine();
                Console.WriteLine($"${a}$");
            }
        }
    }
}
