using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstN = Console.ReadLine().TrimStart('0');

            int secondN = int.Parse(Console.ReadLine());

            List<char> FirstNumber = firstN.ToList();
            FirstNumber.Reverse();
            string output = string.Empty;
            int naum = 0;
            for (int i = 0; i < FirstNumber.Count(); i++)
            {
                int firstnumber = Convert.ToInt32(FirstNumber[i].ToString());

                if (firstnumber * secondN > 9)
                {
                    int result = firstnumber * secondN;
                    if (naum > 0)
                    {
                        output += (naum + result) % 10;
                        if (result + naum > 9)
                        {
                            naum = (naum + result) / 10;
                        }
                        else
                        {
                            naum = 0;
                        }
                    }
                    else
                    {
                        naum = result / 10;
                        output += result % 10;
                    }


                }
                else
                {
                    int result = firstnumber * secondN;
                    if (naum > 0)
                    {
                        output += (naum + result) % 10;
                        if (result + naum > 9)
                        {
                            naum = (naum + result) / 10;
                        }
                        else
                        {
                            naum = 0;
                        }
                    }
                    else
                    {
                      
                        output += result.ToString();
                    }
                }


            }
            if (naum > 0)
            {
                output += naum.ToString();

            }
            List<char> Output = output.ToList();
            Output.Reverse();

            if (secondN == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(string.Join("", Output));
            }
        }
    }
}
