using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TextFilter1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Banned = Console.ReadLine().Split(", ").ToArray();
            string Text = Console.ReadLine();
            Text.Re
            foreach (var item in Banned)
            {
                Text = Regex.Replace(Text, item, new string('*', item.Length));
            }
            Console.WriteLine(Text);

        }
    }
}
