using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] products = Console.ReadLine().Split(' ').ToArray();

            // quantity will have different length
            long[] quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            double[] price = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            string productname = "";

            long quantityoftheproduct = long.MaxValue;

            int index = int.MaxValue;


            while (true)
            {
                string[] productsandquantity = Console.ReadLine().Split(' ').ToArray();

                try
                {
                    productname = productsandquantity[0];
                    quantityoftheproduct = Convert.ToInt64(productsandquantity[1]);
                }
                catch (Exception)
                {

                    break;
                }

                index = Array.IndexOf(products, productname);

                try
                {

                    if (quantityoftheproduct <= quantity[index])
                    {
                        Console.WriteLine("{0} x {1} costs {2:f2}", productname, quantityoftheproduct, quantityoftheproduct * price[index]);
                        quantity[index] -= quantityoftheproduct;
                    }
                    else
                    {
                        Console.WriteLine("We do not have enough {0}", productname);
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("We do not have enough {0}", productname);
                }
               



            }



        }
    }
}
