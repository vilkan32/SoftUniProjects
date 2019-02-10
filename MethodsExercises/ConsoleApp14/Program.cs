using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        
            public static void Main()
            {
                string text = Console.ReadLine();
                int next = int.Parse(Console.ReadLine());

                const char Search = 'p';
                bool hasMatch = false;

                for (int i = 0; i < text.Length; i++)
                {
                char checker = text[i];
                    if (checker == Search)
                    {
                        hasMatch = true;

                        int endIndex = next;

                        if (endIndex >= text.Length - i)
                        {
                            endIndex = text.Length - i - 1;
                        }
                    string tooutput = "";

                    for (int r = 1; r <= endIndex; r++)
                    {
                        tooutput += text[r + i];
                    }
                    string matchedString = tooutput;
                        Console.WriteLine("p" + matchedString);
                        i += next;
                    }
                }

                if (!hasMatch)
                {
                    Console.WriteLine("no");
                }
            }
        
    }
}
