using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in input)
            {
                var regex = Regex.Match(item, @"^\-?\d+(\.\d+)?$");

                if (regex.Success == true)
                {
                    Console.Write(regex.Value + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
