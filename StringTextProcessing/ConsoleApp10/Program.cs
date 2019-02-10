using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstN = Console.ReadLine();
            firstN = firstN.TrimStart('0');
            string secondN = Console.ReadLine();
            secondN = secondN.TrimStart('0');
            List<char> FirstNumber = firstN.ToList();
            List<char> SecondNumber = secondN.ToList();
            List<int> Result = new List<int>();
            int naum = 0;
            FirstNumber.Reverse();
            SecondNumber.Reverse();

            string result = "";
            
            
            for (int i = 0; i < Math.Min(FirstNumber.Count(), SecondNumber.Count()); i++)
            {
                int first = Convert.ToInt32(FirstNumber[i].ToString());
                int second = Convert.ToInt32(SecondNumber[i].ToString());

                if (first + second > 9)
                {
                    if (naum == 1)
                    {
                        if (first + second + naum > 9)
                        {
                            result += (first + second + 1) % 10;
                            naum = 1;
                        }
                        else
                        {
                            result += (first + second + 1);
                            naum = 0;
                        }
                    }
                    else
                    {
                        result += (first + second) % 10;
                        naum = 1;
                    }
                    
                }
                else
                {
                    if (naum == 1)
                    {
                        if (first + second + naum > 9)
                        {
                            result += (first + second + 1) % 10;
                            naum = 1;
                        }
                        else
                        {
                            result += (first + second + 1);
                            naum = 0;
                        }
                    }
                    else
                    {
                        result += (first + second);
                    }
                }
                

            }


            if (FirstNumber.Count() < SecondNumber.Count())
            {

                for (int i = FirstNumber.Count(); i < SecondNumber.Count(); i++)
                {
                    int first = 0;
                    try
                    {
                        first = Convert.ToInt32(FirstNumber[i].ToString());
                    }
                    catch (Exception)
                    {

                       
                    }
                    int second = Convert.ToInt32(SecondNumber[i].ToString());

                    if (naum == 1)
                    {
                        if (first + second + naum > 9)
                        {
                            result += (first + second + 1) % 10;
                            naum = 1;
                        }
                        else
                        {
                            result += (first + second + 1);
                            naum = 0;
                        }
                    }
                    else
                    {
                        result += (first + second);
                    }
                }

            }
            else if(FirstNumber.Count > SecondNumber.Count())
            {
                for (int i = SecondNumber.Count(); i < FirstNumber.Count(); i++)
                {
                    int first = Convert.ToInt32(FirstNumber[i].ToString());
                    int second = 0;
                    try
                    {
                        second = Convert.ToInt32(SecondNumber[i].ToString());
                    }
                    catch (Exception)
                    {

                        second = 0;
                    }

                    if (naum == 1)
                    {
                        if (first + second + naum > 9)
                        {
                            result += (first + second + 1) % 10;
                            naum = 1;
                        }
                        else
                        {
                            result += (first + second + 1);
                            naum = 0;
                        }
                    }
                    else
                    {
                        result += (first + second);
                    }
                }
            }

            if (naum == 1)
            {
                result += "1";
            }
          

                List<char> Output = result.ToList();
            Output.Reverse();
            Console.WriteLine(string.Join("",Output));

        }
    }
}
