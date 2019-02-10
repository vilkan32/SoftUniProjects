using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {

            string Input = Console.ReadLine();
            var numberList = Regex.Matches(Input, @"[0-9]").Cast<Match>().Select(a => a.Value).ToList();
            Input = Regex.Replace(Input, @"[0-9]", "");

            List<int> TakeList = new List<int>();
            List<int> SkipList = new List<int>();

            for (int i = 0; i < numberList.Count(); i++)
            {
                if (i % 2 == 0)
                {
                    // even
                    TakeList.Add(int.Parse(numberList[i]));
                }
                else
                {
                    // odd
                    SkipList.Add(int.Parse(numberList[i]));
                }

            }
            string output = "";
            int indexer = TakeList.Count();
            int counter = 0;
            for (int i = 0; i < Input.Count(); i++)
            {
                if (counter == indexer)
                {
                    break;
                }
                for (int x = i; x < TakeList[counter] + i; x++)
                {
                    try
                    {
                        output += Input[x];
                    }
                    catch (Exception)
                    {

                        break;
                    }
                }
                i += TakeList[counter] - 1;
                i += SkipList[counter];
                counter++;

            }

            Console.WriteLine(output);
        }
    }
}
