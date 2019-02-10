using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncrptSortPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            List<long> FinalsSum = new List<long>();
            for (int i = 0; i < a; i++)
            {
                char[] Vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
                
                string Input = Console.ReadLine();
                List<long> VowelsSum = new List<long>();
                List<long> ConsonantSum = new List<long>();
                for (int x = 0; x < Input.Length; x++)
                {
                    if (Vowels.Contains(Input[x]))
                    {
                        long inspect = Input[x];
                        VowelsSum.Add(inspect * Input.Length);
                    }
                    else
                    {

                        long inspect = Input[x];
                        ConsonantSum.Add(inspect / Input.Length);
                    }

                   
                }

                FinalsSum.Add(VowelsSum.Sum() + ConsonantSum.Sum());
            }

            foreach (var item in FinalsSum.OrderBy(x => x))
            {
                Console.WriteLine(item);
            }
        }
    }
}
