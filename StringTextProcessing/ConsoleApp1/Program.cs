using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string matchingtext = Console.ReadLine().ToLower();
            List<char> Listofchar = text.ToList();
            int counter = 0;
            int numberofstops = matchingtext.Length;
           
            string match = "";

            for (int i = 0; i <= Listofchar.Count() - numberofstops; i++)
            {
                if (Listofchar[i] == matchingtext[0])
                {
                    match += Listofchar[i];
                    for (int x = i + 1; x < i + matchingtext.Length; x++)
                    {
                        match += Listofchar[x];
                    }
                    if (match == matchingtext)
                    {
                        counter++;
                    }
                    match = "";
                }
            }

            Console.WriteLine(counter);
        }
    }
}
