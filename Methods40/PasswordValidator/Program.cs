using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            int numberofdigits = 0; // at least two
            int numberofletters = 0; // numofdigits + numofletters >=6 && <= 10
            int numberofspecialcharacters = 0;
            // 65 - 90 A-Z 97 - 122 a-z 48 - 57 0 - 9
            foreach (var item in input)
            {
                if (item >= 65 && item <= 90)
                {
                    numberofletters++;
                }
                else if (item >= 97 && item <= 122)
                {
                    numberofletters++;
                }
                else if (item >= 48 && item <= 57)
                {
                    numberofdigits++;
                }
                else
                {
                    numberofspecialcharacters++;
                }
            }


            int length = input.Length;

            string answerregerdingnumberofcharacters = "Password must be between 6 and 10 characters"; // 1
            string answerregardingthenumberofdigits = "Password must have at least 2 digits"; // 2
            string valid = "Password is valid"; // 3
            string regardingspecialcharacters = "Password must consist only of letters and digits"; // 4
            int counterfortherightpassword = 0;

            if (length >= 6 && length <= 10)
            {
                counterfortherightpassword++;
            }
            else
            {
                Console.WriteLine(answerregerdingnumberofcharacters);
            }

            if (numberofspecialcharacters >= 1)
            {
                Console.WriteLine(regardingspecialcharacters);
            }
            else
            {
                counterfortherightpassword++;
            }

            if (numberofdigits >= 2 )
            {
                counterfortherightpassword++;
            }
            else
            {
                Console.WriteLine(answerregardingthenumberofdigits);
            }

            if (counterfortherightpassword == 3)
            {
                Console.WriteLine(valid);
            }
        }
    }
}
