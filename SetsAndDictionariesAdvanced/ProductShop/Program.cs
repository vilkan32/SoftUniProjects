using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> StoreProductPrice = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(", ");

                if (input[0] == "Revision")
                {
                    break;
                }

                if (!StoreProductPrice.ContainsKey(input[0]))
                {
                    StoreProductPrice.Add(input[0], new Dictionary<string, double>());
                    StoreProductPrice[input[0]].Add(input[1], double.Parse(input[2]));
                }
                else
                {
                    StoreProductPrice[input[0]].Add(input[1], double.Parse(input[2]));
                }
              

            }


            foreach (var item in StoreProductPrice)
            {
                Console.WriteLine(item.Key+"->");

                foreach (var set in item.Value)
                {
                    Console.WriteLine("Product: {0}, Price: {1}", set.Key, set.Value);
                }
            }
        }
    }
}
