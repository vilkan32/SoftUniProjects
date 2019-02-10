using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PurchaseList> SumProducts = new List<PurchaseList>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }
                string pattern = @"[%]([A-Z][a-z]+)[%][^|$%.]*?<(\w+)>[^|$%.]*?[|](\d+)[|][^|$%.]*?(\d+[.]?\d+)[$]";

                var match = Regex.Match(input, pattern);
                if (match.Success == false)
                {
                    continue;
                }
                PurchaseList CurrentList = new PurchaseList();
                CurrentList.Name = match.Groups[1].ToString();
                CurrentList.NameProduct = match.Groups[2].ToString();
                CurrentList.Quantity = Convert.ToInt32(match.Groups[3].ToString());
                string number = match.Groups[4].ToString();
                CurrentList.Price = double.Parse(number, CultureInfo.InvariantCulture);
                CurrentList.Totalsum = CurrentList.Price * CurrentList.Quantity;
                SumProducts.Add(CurrentList);
            }
            double income = 0;
            foreach (var item in SumProducts)
            {
                Console.WriteLine("{0}: {1} - {2:f2}", item.Name,item.NameProduct,item.Totalsum);
                income += item.Totalsum;

            }
            Console.WriteLine("Total income: {0:f2}", income);
        }
    }
    class PurchaseList
    {
        public string Name { get; set; }
        public string NameProduct { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Totalsum { get; set; }

    }
}
