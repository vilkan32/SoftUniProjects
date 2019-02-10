using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Sales[] AllProducts = new Sales[a];
            for (int i = 0; i < a; i++)
            {
                AllProducts[i] = new Sales();
            }
            SortedDictionary<string, double> TownMoney = new SortedDictionary<string, double>();
            foreach (var item in AllProducts)
            {
                if (!TownMoney.ContainsKey(item.Town))
                {
                    TownMoney.Add(item.Town, 0);
                }
                TownMoney[item.Town] += item.Price * item.Quantity;
            }
            foreach (var item in TownMoney)
            {
                Console.WriteLine("{0} -> {1:f2}", item.Key, item.Value);
            }
            
        }
    }
    class Sales
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();

        public string Town { get { return this.input[0]; } }
        public string Product { get { return this.input[1]; } }
        public double Price { get { return Convert.ToDouble(this.input[2]); } }
        public double Quantity { get { return Convert.ToDouble(this.input[3]); } }
    }

}
