using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            const string pattern = "(?<=<p>).+?(?=<\\/p>)";
            var regex = new Regex(pattern);
            var sb = new StringBuilder();


        }
    }
}