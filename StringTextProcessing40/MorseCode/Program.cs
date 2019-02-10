using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string input = Console.ReadLine();

            var regex = input.Split(@"\s+");
            StringBuilder sb = new StringBuilder();
            foreach (var item in regex)
            {
                Dictionary<string, char> MorseCode = new Dictionary<string, char>
            {
                { ".-" ,'A'},
                {"-...", 'B'},
                {"-.-.",'C' },
                { "-..",'D' },
                {"." ,'E'},
                {"..-.",'F' },
                { "--.", 'G'},
                { "....", 'H'},
                { "..", 'I'},
                {".---", 'J' },
                {"-.-", 'K' },
                {".-..", 'L' },
                {"--", 'M' },
                {"-.", 'N'},
                {"---", 'O'},
                {".--.", 'P'},
                {"--.-", 'Q'},
                {".-.", 'R'},
                {"...", 'S'},
                {"-", 'T'},
                {"..-", 'U'},
                {"...-", 'V'},
                {".--", 'W'},
                {"-..-", 'X' },
                {"-.--", 'Y'},
                {"--..", 'Z'}
            };
                if (item == @"|")
                {
                    sb.Append(" ");
                }
                else
                {
                    sb.Append(MorseCode[item]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
