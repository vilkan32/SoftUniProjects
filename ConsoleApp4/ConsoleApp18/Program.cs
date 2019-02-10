using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {



            double capacity = double.Parse(Console.ReadLine());

            string package = Console.ReadLine();

            double smallhall = 2500; // za 50

            double terrace = 5000; // za 100

            double greathall = 7500;// za 120 

            double totalprice = 0;

            double discount = 0;

            if (capacity <= 50 && package == "Normal")
            {
                totalprice = smallhall + 500;
                discount = totalprice - (totalprice * 5 / 100);


                Console.WriteLine("We can offer you the Small Hall \nThe price per person is {0:f2}$", discount / capacity);
            }
            else if (capacity <= 50 && package == "Gold")
            {
                totalprice = smallhall + 750;
                discount = totalprice - (totalprice  * 10 / 100);

                
                Console.WriteLine("We can offer you the Small Hall \nThe price per person is {0:f2}$", discount/ capacity);
            }
            else if (capacity <= 50 && package == "Platinum")
            {
                totalprice = smallhall + 1000; // cen na paketa
                discount = totalprice - (totalprice * 15 / 100);


                Console.WriteLine("We can offer you the Small Hall \nThe price per person is {0:f2}$", discount / capacity);
            }
           


            else if (capacity > 50 && capacity <=100 && package == "Normal")
            {
                totalprice = terrace + 500;
                discount = totalprice - (totalprice * 5 / 100);


                Console.WriteLine("We can offer you the Terrace \nThe price per person is {0:f2}$", discount / capacity);
            }
            else if (capacity > 50 && capacity <= 100&& package == "Gold")
            {
                totalprice = terrace + 750;
                discount = totalprice - (totalprice * 10 / 100);


                Console.WriteLine("We can offer you the Terrace \nThe price per person is {0:f2}$", discount / capacity);
            }
            else if (capacity > 50 && capacity <= 100&& package == "Platinum")
            {
                totalprice = terrace + 1000; // cen na paketa
                discount = totalprice - (totalprice * 15 / 100);


                Console.WriteLine("We can offer you the Terrace \nThe price per person is {0:f2}$", discount / capacity);
            }

            else if (capacity > 100 && capacity <= 120 && package == "Normal")
            {
                totalprice = greathall + 500;
                discount = totalprice - (totalprice * 5 / 100);


                Console.WriteLine("We can offer you the Great Hall \nThe price per person is {0:f2}$", discount / capacity);
            }
            else if (capacity > 100 && capacity <= 120 && package == "Gold")
            {
                totalprice = greathall + 750;
                discount = totalprice - (totalprice * 10 / 100);


                Console.WriteLine("We can offer you the Great Hall \nThe price per person is {0:f2}$", discount / capacity);
            }
            else if (capacity > 100 && capacity <= 120 && package == "Platinum")
            {
                totalprice = greathall + 1000; // cen na paketa
                discount = totalprice - (totalprice * 15 / 100);


                Console.WriteLine("We can offer you the Great Hall \nThe price per person is {0:f2}$", discount / capacity);
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }


        }
    }
}
