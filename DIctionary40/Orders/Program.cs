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
            List<Products> Cart = new List<Products>();
            while (true)
            {
                List<string> Input = Console.ReadLine().Split(' ').ToList();
                if (Input[0] == "buy")
                {
                    break;
                }
                string name = Input[0];
                double price = double.Parse(Input[1], System.Globalization.CultureInfo.InvariantCulture);
                int quntity = int.Parse(Input[2]);

                
               
            }

            foreach (var item in Cart)
            {
                Console.WriteLine(item.Name + " -> " + "{0:f2}", item.Quantity * item.Price);
            }

        }
    }
    class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

    }
}
