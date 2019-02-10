using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Regex.Replace(Console.ReadLine(), @"\s", "");
            List<int> BombPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var match = Regex.Matches(input, @"\d{0," + BombPower[1] + "}" + BombPower[0] + @"\d{0," + BombPower[1] + "}");

            foreach (var item in match)
            {
                input = Regex.Replace(input, item.ToString(), "");
            }
            int displaysum = 0;
            foreach (var item in input)
            {
                displaysum += Convert.ToInt32
                (item.ToString());
            }
            Console.WriteLine(displaysum);
        }
    }
}
