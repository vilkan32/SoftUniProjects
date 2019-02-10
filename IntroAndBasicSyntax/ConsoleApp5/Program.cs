using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupnumber = int.Parse(Console.ReadLine());
            string grouptype = Console.ReadLine();
            string day = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> Table = new Dictionary<string, Dictionary<string, double>>();

            Table.Add("Students", new Dictionary<string, double>());
            Table["Students"].Add("Friday", 8.45);
            Table["Students"].Add("Saturday", 9.80);
            Table["Students"].Add("Sunday", 10.46);
            Table.Add("Business", new Dictionary<string, double>());
            Table["Business"].Add("Friday", 10.90);
            Table["Business"].Add("Saturday", 15.60);
            Table["Business"].Add("Sunday", 16);
            Table.Add("Regular", new Dictionary<string, double>());
            Table["Regular"].Add("Friday", 15);
            Table["Regular"].Add("Saturday", 20);
            Table["Regular"].Add("Sunday", 22.50);

            double price = 0;

            if (grouptype == "Students" && groupnumber >= 30)
            {
                price = Table[grouptype][day] * groupnumber - (Table[grouptype][day] * groupnumber * 15/100);
            }
            else if (grouptype == "Business" && groupnumber >= 100)
            {
                price = Table[grouptype][day] * (groupnumber - 10);
            }
            else if (grouptype == "Regular" && groupnumber >= 10 && groupnumber <= 20)
            {
                price = Table[grouptype][day] * groupnumber - (Table[grouptype][day] * groupnumber * 5 / 100);
            }
            else
            {
                price = Table[grouptype][day] * groupnumber;
            }
            Console.WriteLine("Total price: {0:f2}", price);
        }
    }
}
