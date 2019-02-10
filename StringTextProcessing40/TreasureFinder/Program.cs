using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Keys = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "find")
                {
                    break;
                }
                int index = 0;
                string result = string.Empty;
                for (int i = 0; i < input.Length; i++)
                {
                    result += Convert.ToChar(input[i] - Keys[index]);
                    if (index == Keys.Length - 1)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                   
                }
                var treasure = Regex.Match(result, @"\&([^&]+)\&");
                var coordinates = Regex.Match(result, @"\<([^>]+)\>");
                if (treasure.Success == true && coordinates.Success == true)
                {
                    Console.WriteLine("Found {0} at {1}", treasure.Groups[1], coordinates.Groups[1]);
                }
            }
        }
    }
}
