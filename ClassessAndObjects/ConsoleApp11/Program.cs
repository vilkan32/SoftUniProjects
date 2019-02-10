using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Dictionary<string,decimal> ProductList = new Dictionary<string, decimal>();

            for (int i = 0; i < a; i++)
            {
                string[] Products = Console.ReadLine().Split('-').ToArray();

                string name = Products[0];
                decimal price = Convert.ToDecimal(Products[1]);
                if (!ProductList.ContainsKey(name))
                {
                    ProductList.Add(name, 0);
                }
                ProductList[name] = price;

            }

            List<Clients> ClientsList = new List<Clients>();
            while (true)
            {
                string[] Requests = Console.ReadLine().Split(new char[] { '-', ','}).ToArray();
                if (Requests[0] == "end of clients")
                {
                    break;
                }
                Clients someinput = new Clients();

                int counter = 0;
                someinput.Name = Requests[0];
                someinput.Product = new Dictionary<string, int>();
                someinput.Product.Add(Requests[1],Convert.ToInt32(Requests[2]));
                for (int i = 0; i < ClientsList.Count(); i++)
                {
                    if (ClientsList[i].Name == someinput.Name && ProductList.ContainsKey(Requests[1]))
                    {
                        ClientsList[i].Product.Add(Requests[1], Convert.ToInt32(Requests[2]));
                        counter++;
                        break;
                    }
                    
                }
                if (counter==0 && ProductList.ContainsKey(Requests[1]))
                {
                    ClientsList.Add(someinput);
                    counter = 0;
                }
              
            }
            
            List<decimal> Toatalsum = new List<decimal>();
           
            foreach (var item in ClientsList.OrderBy(x => x.Name).ToList())
            {
                List<decimal> BillSum = new List<decimal>();
                Console.WriteLine("{0}", item.Name);
                    foreach (var items in item.Product)
                    {
                        Console.WriteLine("-- {0} - {1}", items.Key, items.Value);
                        BillSum.Add(items.Value * ProductList[items.Key]);
                        Toatalsum.Add(items.Value * ProductList[items.Key]);

                    }
                    Console.WriteLine("Bill: {0:f2}", BillSum.Sum());
                   
                
            }
            Console.WriteLine("Total bill: {0:f2}", Toatalsum.Sum());
            
        }
    }


    class Clients
    {
        public string Name { get; set; }

        public Dictionary<string, int> Product { get; set; }


    }
}
