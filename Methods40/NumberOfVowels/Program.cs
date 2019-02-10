using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfVowels
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            List<char> Vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A',  'E', 'I', 'O', 'U' };
            int counttodisplay = 0;
            foreach (char item in input)
            {
                if (Vowels.Contains(item))
                {
                    counttodisplay++;
                }
            }

            Console.WriteLine(counttodisplay);
        }
    }
}
