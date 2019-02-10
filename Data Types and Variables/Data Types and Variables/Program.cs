using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            for (int i = 1; i <= 1; i++)
            {
                try
                {
                    sbyte.Parse(input);
                    Console.WriteLine("Sunny");
                    break;

                }
                catch (Exception)
                {


                }
                try
                {
                    int.Parse(input);
                    Console.WriteLine("Cloudy");
                    break;
                }
                catch (Exception)
                {


                }
                try
                {
                    long.Parse(input);
                    Console.WriteLine("Windy");
                    break;
                }
                catch (Exception)
                {


                }
                try
                {
                    decimal.Parse(input) ;
                    Console.WriteLine("Rainy");
                    break;
                }
                catch (Exception)
                {


                }

            }


        }
    }
}
