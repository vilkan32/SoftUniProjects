using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in input)
            {
                var regex = Regex.Match(item.TrimEnd('.'), @"\G(?<![-.])([A-Za-z0-9]+)([.-]?[A-Za-z0-9]+)@[A-Za-z0-9]+([.-]?[A-Za-z0-9]+)*");
                if (regex.Success == true)  
                {
                    Console.WriteLine(item.TrimEnd('.'));
                }
            }
        }
    }
}
