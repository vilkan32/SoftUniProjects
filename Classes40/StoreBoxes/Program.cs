using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> Item4eta = new List<Box>();
            while (true)
            {
                string[] Items = Console.ReadLine().Split(' ').ToArray();

                if (Items[0] == "end")
                {
                    break;
                }
                Box local = new Box();
                local.SerialNumber = Items[0];
                local.ItemName = Items[1];
                local.Quantity = int.Parse(Items[2]);
                local.Price = double.Parse(Items[3], System.Globalization.CultureInfo.InvariantCulture);
                local.TotalPrice = local.Price * local.Quantity;
                Item4eta.Add(local);
            }

            foreach (var item in Item4eta.OrderByDescending(x => x.TotalPrice))
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine("-- {0} - ${1:f2}: {2}", item.ItemName, item.Price, item.Quantity);
                Console.WriteLine("-- ${0:f2}", item.TotalPrice);

            }
        }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get;set; }
       
    }
}
