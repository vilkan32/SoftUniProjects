using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] People = Console.ReadLine().Split(new char[] { ';'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<Person> Custommers = new List<Person>();
            foreach (var item in People)
            {
                string[] result = item.Split('=').ToArray();
                Person local = new Person();
                local.Name = result[0];
                local.Money = double.Parse(result[1]);
                local.ListProducts = new List<string>();
                Custommers.Add(local);
            }
            string[] Product = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<Products> Goods = new List<Products>();

            foreach (var item in Product)
            {
                string[] result = item.Split('=').ToArray();
                Products local = new Products();
                local.Name = result[0];
                local.Price = double.Parse(result[1]);
                Goods.Add(local);

            }

            while (true)
            {
                string[] inp = Console.ReadLine().Split(' ').ToArray();
                if (inp[0] == "END")
                {
                    break;
                }
                double price = 0;
                for (int i = 0; i < Custommers.Count(); i++)
                {
                    if (Custommers[i].Name == inp[0])
                    {
                        for (int x = 0; x < Goods.Count(); x++)
                        {
                            if (Goods[x].Name == inp[1])
                            {
                                price = Goods[x].Price;
                                break;
                            }
                        }
                        if (Custommers[i].Money >= price)
                        {
                            Console.WriteLine("{0} bought {1}", Custommers[i].Name, inp[1]);
                            Custommers[i].Money = Custommers[i].Money - price;
                            Custommers[i].ListProducts.Add(inp[1]);
                        }
                        else
                        {
                            Console.WriteLine("{0} can't afford {1}", Custommers[i].Name, inp[1]);
                        }
                        
                    }
                }
            }

            foreach (var item in Custommers)
            {
                if (item.ListProducts.Count() == 0)
                {
                    Console.WriteLine("{0} - Nothing bought", item.Name);
                }
                else
                {
                    Console.WriteLine("{0} - {1}", item.Name, string.Join(", ", item.ListProducts));
                }
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public List<string> ListProducts { get; set; }

    }

    class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
