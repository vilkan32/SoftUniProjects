using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace BakingMasterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // The educational set for one student consists of 1 package of flour, 10 eggs and an apron. 

            double budget = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double students = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint);
            double priceFlour = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint);
            double priceEggs = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint);
            double priceApron = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint);

            // Because the aprons get dirty often, Peter should buy 20% more, rounded up to the next integer. Also, every fifth package of flour is free. 

            double PriceForFlour = 0;
            int countforfives = 1;
            double priceforAprons = priceApron * (students + (Math.Ceiling(students * 0.20)));

            double priceforeggs = priceEggs * students * 10;


            for (int i = 1; i <= students; i++)
            {
                if (countforfives == 5)
                {
                    countforfives = 0;
                }
                else
                {
                    PriceForFlour += priceFlour;
                }
                countforfives++;
            }

            double sumtopurcase = PriceForFlour + priceforAprons + priceforeggs;

            if (budget >= sumtopurcase)
            {
                Console.WriteLine("Items purchased for {0:f2}$.", sumtopurcase);
            }
            else
            {
                Console.WriteLine("{0:f2}$ more needed.", sumtopurcase -budget);
            }

        }
    }
}
