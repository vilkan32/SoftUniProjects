using System;
using System.Text.RegularExpressions;
namespace SecondTas
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string decoded = string.Empty;

            foreach (var item in input)
            {
                decoded += Convert.ToChar(item - 3);
            }
            string[] Pattern = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var regex = Regex.Replace(decoded, Regex.Escape(Pattern[0]), Regex.Escape(Pattern[1]));
            if (Regex.Match(input, @"[^d-z{}|#]").Success == true)
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
            else
            {
                Console.WriteLine(regex.ToString());
            }
            
        }
    }
}
