using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<char> Input = Console.ReadLine().ToList();
                if (Input[0] == 'E'&& Input[1] == 'N' && Input[2] == 'D')
                {
                    break;
                }
                
                string first = "";
                string second = "";



                List<char> test = Input;
                    for (int x = 0; x < test.Count() / 2; x++)
                    {
                        first += test[x];
                    }
                    test.Reverse();
                    for (int y = 0; y < test.Count() / 2; y++)
                    {
                        second += test[y];
                    }

                    if (first == second)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                    first = "";
                    second = "";

                
            

        }
    }
}
    }
