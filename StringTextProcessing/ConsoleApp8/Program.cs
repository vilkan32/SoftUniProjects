using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Input = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string currword = "";
            string first = "";
            string second = "";
            List<string> Output = new List<string>();
            for (int i = 0; i < Input.Count(); i++)
            {
                currword = Input[i];
                List<char> test = currword.ToList();
                for (int x = 0; x < currword.Length / 2; x++)
                {
                    first += test[x];
                }
                test.Reverse();
                for (int y = 0; y < currword.Length / 2; y++)
                {
                    second += test[y];
                }
                if (first == second && !Output.Contains(currword))
                {
                    Output.Add(currword);
                }
                first = "";
                second = "";

            }
            Output.Sort();
           
            Console.WriteLine(string.Join(", ", Output));


        }
    }
}
