using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> ProductsPricesQuantity = new Dictionary<string, List<double>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stocked")
                {
                    break;
                }
                List<string> Input = input.Split(' ').ToList();

                double price = Convert.ToDouble(Input[1]);
                int quantity = Convert.ToInt32(Input[2]);

                if (!ProductsPricesQuantity.ContainsKey(Input[0]))
                {
                    ProductsPricesQuantity.Add(Input[0], new List<double>());
                    ProductsPricesQuantity[Input[0]].Add(price);
                    ProductsPricesQuantity[Input[0]].Add(quantity);
                }
                else
                {
                    ProductsPricesQuantity[Input[0]][0] = price;
                    ProductsPricesQuantity[Input[0]][1] += quantity;
                }             
            }
            List<double> Sum = new List<double>();
            foreach (var item in ProductsPricesQuantity)
            {
               
                    Sum.Add(item.Value[0] * item.Value[1]);
                Console.WriteLine("{0}: ${1:f2} * {2} = ${3:f2}", item.Key, item.Value[0], item.Value[1], item.Value[0] * item.Value[1]); 
               

            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Grand Total: ${0:f2}", Sum.Sum());
        }
    }
}
