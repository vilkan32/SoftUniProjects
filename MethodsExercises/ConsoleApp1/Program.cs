using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstdigittocompare = double.Parse(Console.ReadLine());
            double outputtocompare = double.MinValue;

            for (int i = 1; i <= 6; i++)
            {
                double nextdigits = double.Parse(Console.ReadLine());

                double output = GetMax(firstdigittocompare, nextdigits);
                

                firstdigittocompare = nextdigits;




                if (output >= outputtocompare)
                {
                    
                }
                
                    Console.WriteLine(GetMax(output, outputtocompare));
                
                outputtocompare = output;
            }
            
            
        }

        static double GetMax(double first, double second) 
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }

        }
    }
}
