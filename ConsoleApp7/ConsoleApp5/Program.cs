using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> Input = Console.ReadLine().Split(new[] { ' ', ',', ';', ':', '.', '!',
                '(', ')', '"',
                '\u0027',
                '\\', '/',
                '[', ']'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            int broipteminavaniqupper = 0;
            int broipteminavaniqlower = 0;
            int broipteminavaniqmixed = 0;


            List<string> LowerCase = new List<string>();
            List<string> UpperCase = new List<string>();
            List<string> MixedCase = new List<string>();

            for (int i = 0; i < Input.Count; i++)
            {

                string item = Input[i];

                for (int c = 0; c < item.Length; c++)
                {
                    if (item[c] <= 90 && item[c] >= 65)
                    {
                        broipteminavaniqupper++;
                    }
                    else if (item[c] >= 97 && item[c] <=122)
                    {
                        broipteminavaniqlower++;
                    }
                    else
                    {
                        broipteminavaniqmixed++;
                    }
                }

                if (broipteminavaniqlower == 0 && broipteminavaniqupper != 0 && broipteminavaniqmixed ==0)
                {
                    UpperCase.Add(item);
                }
                else if (broipteminavaniqlower != 0 && broipteminavaniqupper == 0 && broipteminavaniqmixed == 0)
                {
                    LowerCase.Add(item);
                }
                else if (broipteminavaniqmixed > 0)
                {
                    MixedCase.Add(item);
                }
                else
                {
                    MixedCase.Add(item);
                }
               
                broipteminavaniqupper = 0;
                broipteminavaniqlower = 0;
                broipteminavaniqmixed = 0;
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", LowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", MixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", UpperCase));
        }
    }
}
