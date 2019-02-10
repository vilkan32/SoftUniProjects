using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Input = Console.ReadLine().Split(' ').ToList();
            List<char> Output = new List<char>();
            string reversednumber = "";
            int a = 0;
            int numbertoparse = int.MaxValue;
            int result = 0;
            foreach (string number in Input)
            {

                for (int i = number.Length - 1 ; i >= 0; i--)
                {
                    Output.Add(number[i]);
                    reversednumber += Convert.ToString(Output[a]);
                    a++;
                        
                }
                numbertoparse = Convert.ToInt32(reversednumber);
                result += numbertoparse;
                numbertoparse = int.MaxValue;
                reversednumber = "";
            }

            Console.WriteLine(result);




        }
    }
}
