using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            string numbertostring = number.ToString();

            for (int i = 1; i <= number; i++)
            {
                string itostring = i.ToString();

                bool coulcitbedividedby7 = GetDivBySevenNumbers(i, itostring);

                bool issymmetric = GetSymmetricOrNot(itostring);

                bool HoldsOneEvenDigit = GetEvenDigit(i, itostring);

                if (coulcitbedividedby7 && issymmetric && HoldsOneEvenDigit)
                {
                    Console.WriteLine(i);
                }
            }
            

        }

         static bool GetEvenDigit(double number, string numbertostring)
        {

            bool returnwhatever = true;

            double sumofthedigits = 0;
            

            double stringlength = numbertostring.Length;
            for (int i = 1; i <= stringlength; i++)
            {
                sumofthedigits = (int)number % 10;
                if (sumofthedigits % 2 == 0)
                {
                    returnwhatever = true;
                    break;
                }
                else
                {
                    returnwhatever = false;
                    
                }
                number = (int)number / 10;


            }
            return returnwhatever;
        }

        static bool GetDivBySevenNumbers(double number, string numbertostring)
        {

            
            bool returnwhatever = true;

            double sumofthedigits = 0;
            double stringlength = numbertostring.Length;
            for (int i = 1; i <= stringlength; i++)
            {
                sumofthedigits += (int)number % 10;
                number = (int)number / 10;

            
            }

           if (sumofthedigits % 7 == 0)
            {
                returnwhatever = true;
            }
            else
            {
                returnwhatever = false;
            }
            return returnwhatever;
        }


            static bool GetSymmetricOrNot(string n)
            {
                double stringlenght = n.Length;
                string tocompare = "";
                for (double i = stringlenght - 1; i >= 0; i--)
                {
                    tocompare += n[(int)i];
                }
                if (tocompare == n)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        
    }
}
