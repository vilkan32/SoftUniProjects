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

            List<string> Input = new List<string>();
            
            Input.Add(Console.ReadLine()); 
            Input.Add(Console.ReadLine());
        
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of comments")
                {
                    break;
                }
                else
                {
                    Input.Add(input);
                }
            
            }

            for (int i = 0; i < Input.Count(); i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("<h1>");
                    Console.WriteLine(Input[i]);
                    Console.WriteLine(@"</h1>");
                }
                else if (i == 1)
                {
                    Console.WriteLine("<article>");
                    Console.WriteLine(Input[i]);
                    Console.WriteLine("</article>");
                }
                else
                {
                    Console.WriteLine("<div>");
                    Console.WriteLine(Input[i]);
                    Console.WriteLine("</div>");
                }
            }
        }
    }
}
