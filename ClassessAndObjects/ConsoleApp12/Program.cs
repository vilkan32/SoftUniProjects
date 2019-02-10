using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> Products = new Dictionary<string, decimal>();

            for (int i = 0; i < a; i++)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();

                if (!Products.ContainsKey(input[0]))
                {
                    Products.Add(input[0], 0);

                }
                Products[input[0]] = Convert.ToDecimal(input[1]);
            }
            List<Customer> Test = new List<Customer>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] {'-', ',' }).ToArray();

                if (input[0] == "end of clients")
                {
                    break;
                }
                Customer test = new Customer();
                test.ShopList = new Dictionary<string, int>();
                if (Products.ContainsKey(input[1]))
                {
                    test.Name = input[0];
                    test.ShopList.Add(input[1], Convert.ToInt32(input[2]));
                    int counter = 0;
                    for (int i = 0; i < Test.Count(); i++)
                    {
                        if (Test[i].Name == test.Name)
                        {
                            if (!Test[i].ShopList.ContainsKey(input[1]))
                            {
                                Test[i].ShopList.Add(input[1], Convert.ToInt32(input[2]));
                            }
                            else
                            {
                                Test[i].ShopList[input[1]] += Convert.ToInt32(input[2]);
                            }
                            counter++;
                            break;
                        }
                    }
                    if (counter == 0)
                    {
                        Test.Add(test);
                    }
                    else
                    {
                        counter = 0;
                    }
                }
               
            }
            List<decimal> output = new List<decimal>();
            foreach (var item in Test.OrderBy(x => x.Name))
            {
                List<decimal> say = new List<decimal>();
                Console.WriteLine("{0}", item.Name);
                foreach (var items in item.ShopList)
                {
                    Console.WriteLine("-- {0} - {1}", items.Key, items.Value);
                    say.Add(items.Value * Products[items.Key]);
                }
                output.Add(say.Sum());
                Console.WriteLine("Bill: {0:f2}", say.Sum());
            }
            Console.WriteLine("Total bill: {0:f2}", output.Sum());
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        

    }
}
