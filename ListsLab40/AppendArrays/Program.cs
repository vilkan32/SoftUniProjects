using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Input = Console.ReadLine().Split('|').ToList();
            string merged = "";
            for (int i = Input.Count() - 1; i >= 0; i--)
            {
                merged += Input[i] + " ";
            }

            var match = Regex.Matches(merged, @"\s+");

            foreach (var item in match)
            {
                string it = Regex.Escape(item.ToString());
                string a = Regex.Replace(merged, it, " ");
                merged = a;
            }
            Console.WriteLine(merged.TrimStart());
        }
    }
}
