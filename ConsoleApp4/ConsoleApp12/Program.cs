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

            var typeofday = Console.ReadLine();

        int age = int.Parse(Console.ReadLine());
            int price = 0;

            
                if (age >=0 && age <= 18 && typeofday == "Weekday")
                {
                    price = 12;
                Console.WriteLine("{0}$", price);
            }
                else if (age > 16 && age <= 64 && typeofday == "Weekday")
                {
                    price = 18;
                Console.WriteLine("{0}$", price);

            }
                else if (age > 64 && age <= 122 && typeofday == "Weekday")
                {
                    price = 12;
                Console.WriteLine("{0}$", price);

            }
            

          
               else if (age >= 0 && age <= 18 && typeofday == "Weekend")
                {
                    price = 15;
                Console.WriteLine("{0}$", price);
            }
                else if (age > 16 && age <= 64 && typeofday == "Weekend")
                {
                    price = 20;

                Console.WriteLine("{0}$", price);
            }
                else if (age > 64 && age <= 122 && typeofday == "Weekend")
                {
                    price = 15;

                Console.WriteLine("{0}$", price);
            }
            

          
               else if (age >= 0 && age <= 18 && typeofday == "Holiday")
                {
                    price = 5;
                Console.WriteLine("{0}$", price);
            }
                else if (age > 16 && age <= 64 && typeofday == "Holiday" )
                {
                    price = 12;
                Console.WriteLine("{0}$", price);

            }
                else if (age > 64 && age <= 122 && typeofday == "Holiday" )
                {
                    price = 10;
                Console.WriteLine("{0}$", price);



            }
           
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
