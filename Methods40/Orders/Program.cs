using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}", ReturnResult(input, quantity));
        }
        static double ReturnResult(string inp, double quantity)
        {
            //⦁	coffee – 1.50
            //⦁	water – 1.00
            //⦁	coke – 1.40
            //⦁	snacks – 2.00

            Dictionary<string, double> PriceList = new Dictionary<string, double>();

            PriceList.Add("coffee", 1.50);
            PriceList.Add("water", 1.00);
            PriceList.Add("coke", 1.40);
            PriceList.Add("snacks", 2.00);
            if (PriceList.ContainsKey(inp))
            {
                return PriceList[inp] * quantity;
            }
            else
            {
                return 0;
            }

        }

    }
}
