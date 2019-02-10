using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Furniture = new List<string>();
            double total = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Purchase")
                {
                    break;
                }
                var regex = Regex.Match(input, @">>(.+)<<(\d+[\.]?\d+)!(\d+)");
                if (regex.Success == true)
                {
                    Furniture.Add(regex.Groups[1].Value);
                    total += double.Parse(regex.Groups[2].Value) * double.Parse(regex.Groups[3].Value);

                }
            }
            Console.WriteLine("Bought furniture:");

            for (int i = 0; i < Furniture.Count(); i++)
            {
                Console.WriteLine(Furniture[i]);
            }
            Console.WriteLine("Total money spend: {0:f2}", total);
        }
    }
}
