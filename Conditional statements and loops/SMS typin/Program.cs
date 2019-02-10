using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_typin
{
    class Program
    {
        static void Main(string[] args)
        {

            double n = double.Parse(Console.ReadLine());

            double numberofdigits = 0;

            double mainnumber = 0;

            double output = 0;
            char a;
            int result;
            for (int i = 1; i <= n; i++)
            {
                double firstdigits = double.Parse(Console.ReadLine());
                if (firstdigits == 0)
                {
                    Console.Write(" ");
                    continue;
                }
                if (firstdigits/10>1 && firstdigits/100 <1)
                {
                    numberofdigits = 2;
                }
                else if (firstdigits/100 > 1 && firstdigits/ 1000 <1)
                {
                    numberofdigits = 3;
                }
                else if (firstdigits / 1000 > 1)
                {
                    numberofdigits = 4;
                }
                else if (firstdigits / 10 <1)
                {
                    numberofdigits = 1;
                }
                mainnumber = firstdigits % 10;

               
                double offset = (mainnumber - 2) * 3;
                if (mainnumber == 8 || mainnumber == 9)
                {
                    offset += 1;
                }

                double letterindex = offset - 1 + numberofdigits;

                output = letterindex + 97;

                result = Convert.ToInt32(output);
                a = Convert.ToChar(result);
                

                Console.Write("{0}", a);
                


            }




        }
    }
}
