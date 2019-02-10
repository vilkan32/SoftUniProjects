using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HTMLPARESER
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var Title = Regex.Match(input, @"<title>([^\d]+)<\/title>");
            
            Console.WriteLine("Title: {0}", Title.Groups[1].Value);

            var Body = Regex.Match(input, @"<body>(.*?)<\/body>");


            var Content = Regex.Replace(Body.Groups[1].Value, @"<[^<>]+>?", " ");
            var content = Regex.Replace(Content.ToString(), @"\\n", " ");
            var Result = Regex.Replace(content.ToString(), @"-?\d+(\.\d+)?", " ");
            var result = Regex.Replace(Result.ToString(), @"\s+", " ");
            
            Console.WriteLine("Content: {0}", result.ToString().TrimEnd(new char[] { ' ', '\t' }).TrimStart(new char[] { ' ', '\t' }));
        }
    }
}
