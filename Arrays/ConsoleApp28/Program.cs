using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] products = Console.ReadLine().Split(' ').ToArray();

            long[] quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            string[] price = Console.ReadLine().Split(' ').ToArray();

            string input = "";

            int index = int.MaxValue;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "done")
                {
                    break;
                }
                index = Array.IndexOf(products, input);
                Console.WriteLine("{0} costs: {1}; Available quantity: {2}",products[index], price[index],quantity[index]);
            }


        }
    }
}
