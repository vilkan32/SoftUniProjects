using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> Orders = new Queue<int>(orders);
            Console.WriteLine(orders.Max());
            int MaxOrder = 0;
            while (true)
            {
                if (Orders.Any() && quantity - Orders.Peek() >= 0)
                {
                    if (MaxOrder < Orders.Peek())
                    {
                        MaxOrder = Orders.Peek();
                    }

                    quantity -= Orders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            
            if (Orders.Any())
            {
                Console.WriteLine("Orders left: {0}", string.Join(" ", Orders));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }

        }
    }
}
