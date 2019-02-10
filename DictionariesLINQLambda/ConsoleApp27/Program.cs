using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            List<char> Input = new List<char>();


            for (int i = 0; i < input.Length; i++)
            {
                char somechar = input[i];
                Input.Add(somechar);
            }
            List<int> Numbers = new List<int>();
            for (int i = 0; i < Input.Count(); i++)
            {
                if (Input[i]>= '0' && Input[i] <= '9')
                {
                    Numbers.Add(Convert.ToInt32(Input[i].ToString()));

                }

            }
            for (int i = 0; i < Numbers.Count(); i++)
            {
                if (Input.Contains(Convert.ToChar(Numbers[i].ToString())))
                {
                    Input.Remove(Convert.ToChar(Numbers[i].ToString()));
                }
            }
            List<int> take = new List<int>();
            List<int> skip = new List<int>();
            for (int i = 0; i < Numbers.Count; i++)
            {
                if (i% 2 == 0)
                {
                    take.Add(Numbers[i]);
                }
                else
                {
                    skip.Add(Numbers[i]);
                }
            }
            int skipchar = 0;
            string result = "";
            for (int i = 0; i < take.Count(); i++)
            {
                 

                for (int x = skipchar; x < skipchar + take[i]; x++)
                {
                    if (take[i] == 0)
                    {
                        break;
                    }
                    try
                    {
                        result += Input[x];

                    }
                    catch (Exception)
                    {

                        break;
                    }
                }
                skipchar += skip[i] + take[i];
            }

            Console.WriteLine(result);

        }
    }
}
