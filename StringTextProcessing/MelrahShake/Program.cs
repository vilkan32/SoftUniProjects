using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();


            while (true)
            {
                if (input.Contains(pattern))
                {
                    if (pattern == "")
                    {
                        Console.WriteLine("No shake.");
                        break;

                    }
                    var regex = new Regex(Regex.Escape(pattern));
                    var newText = regex.Replace(input, "", 1);
                    input = newText;
                    input = Reverse(input);
                    pattern = Reverse(pattern);
                 

                    if (input.Contains(pattern))
                    {
                        if (pattern == "")
                        {

                            Console.WriteLine("No shake.");
                            break;

                        }
                        regex = new Regex(Regex.Escape(pattern));
                         newText = regex.Replace(input, "", 1);                        
                         input = newText;
                         input = Reverse(input);
                         Console.WriteLine("Shaked it.");
                        pattern = Reverse(pattern);
                       
                        pattern = Remove(pattern);

                    }
                    else
                    {
                        input = Reverse(input);
                        pattern = Reverse(pattern);
                        Console.WriteLine("No shake.");
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }
              
            }
            Console.WriteLine(input);

        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string Remove(string s)
        {
            List<char> Pattern = s.ToList();
            int number = Pattern.Count() / 2;
            Pattern.RemoveAt(number);

            return new string(Pattern.ToArray());
        }


    }
}
 