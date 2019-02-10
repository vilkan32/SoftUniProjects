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
            Dictionary<double, int> Coins = new Dictionary<double, int>();

            Coins.Add(0.1, 0);
            Coins.Add(0.2, 0);
            Coins.Add(0.5, 0);
            Coins.Add(1, 0);
            Coins.Add(2, 0);

            double totalsum = 0;
            Dictionary<string, double> Products = new Dictionary<string, double>();
            double sumoftheproducts = 0;
            Products.Add("nuts", 2.0);
            Products.Add("water", 0.70);
            Products.Add("crisps", 1.50);
            Products.Add("soda", 0.80);
            Products.Add("coke", 1.0);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Start")
                {
                    foreach (var item in Coins)
                    {
                        totalsum += item.Key * item.Value;
                    }
                    break;
                }
                if (Coins.ContainsKey(Convert.ToDouble(input)))
                {
                    Coins[Convert.ToDouble(input)] += 1;
                   
                }
                else
                {
                    Console.WriteLine("Cannot accept {0}", input);
                }

            }

          


            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "end")
                {
                    break;
                }
                if (Products.ContainsKey(input))
                {
                    sumoftheproducts += Products[input];
                    if (totalsum - sumoftheproducts  < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        sumoftheproducts -= Products[input];
                    }
                    else
                    {
                        Console.WriteLine("Purchased {0}", input);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }


            Console.WriteLine("Change: {0:f2}", totalsum - sumoftheproducts);


        }
    }
}
