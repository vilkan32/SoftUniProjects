using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int sumofthenumber = 0;
            

            for (int i = 1; i <= lines; i++)
            {


                if (i<=9)
                {
                    if (i == 5 || i == 7 || i ==11)
                    {
                        Console.WriteLine("{0} -> True",i);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> False",i);
                    }
                }
                else if (i > 9 && i <1000000)
                {
                    double firstdigit = (double)(i % 10);

                    double seconddigit = (double)(i / 10);

                    
                    sumofthenumber += (int)firstdigit + (int)seconddigit;
                    if (sumofthenumber== 5 || sumofthenumber == 11 || sumofthenumber ==7)
                    {
                        Console.WriteLine("{0} -> True", i);

                    }
                    else
                    {
                        Console.WriteLine("{0} -> False", i);
                    }
                    sumofthenumber = 0;

                }


                






            }







        }
    }
}
