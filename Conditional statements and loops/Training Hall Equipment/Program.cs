using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());

            int lines = int.Parse(Console.ReadLine());
            double priceoftheproducts = 0;
            for (int i = 1; i <= lines; i++)
            {
                string productname = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                double count = double.Parse(Console.ReadLine());
                if (count >1)
                {
                    priceoftheproducts += price * count;
                    Console.WriteLine("Adding {0} {1}s to cart.", count, productname);
                }
                else
                {
                    priceoftheproducts += price * count;
                    Console.WriteLine("Adding {0} {1} to cart.", count, productname);
                }
            }

            if (budget - priceoftheproducts > 0)
            {
                Console.WriteLine("Subtotal: ${0:f2}",priceoftheproducts);
                Console.WriteLine("Money left: ${0:f2}", budget - priceoftheproducts);
            }
            else
            {
                Console.WriteLine("Subtotal: ${0:f2}", priceoftheproducts);
                Console.WriteLine("Not enough. We need ${0:f2} more.", priceoftheproducts - budget);
            }
        }
    }
}
