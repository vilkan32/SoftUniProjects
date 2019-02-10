using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            var regex = Regex.Match(input, @"C:\\.+\\(.+\..+)");
            string[] result = regex.Groups[1].Value.ToString().Split('.').ToArray();

           Console.WriteLine("File name: {0}", result[0]);
            Console.WriteLine("File extension: {0}", result[1]);
        }
    }
}
