using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(NumbersViceVerse(number)); 

        }

        static string NumbersViceVerse(double numbers)
        {
            double viceverse = 0;
            double viceverse1 = 0;
            string output = "";
            string output1 = "";
            string output2 = "";
            double imalicifrisledzapetaqta = 0;

            if (numbers > Convert.ToInt32(numbers))
            {
                imalicifrisledzapetaqta = numbers - Convert.ToInt32(numbers);

                imalicifrisledzapetaqta = Math.Round(imalicifrisledzapetaqta, 5);
                double checker = Convert.ToInt32(imalicifrisledzapetaqta);

                while (imalicifrisledzapetaqta * 10 > Convert.ToInt32(imalicifrisledzapetaqta))
                {
                    if (imalicifrisledzapetaqta == Convert.ToInt32(imalicifrisledzapetaqta))
                    {
                        break;
                    }
                    imalicifrisledzapetaqta *= 10;




                }

            }
            else
            {
                int abv = Convert.ToInt32(numbers);
                while (abv > 0)
                {


                    viceverse = Convert.ToInt32(abv);
                    viceverse %= 10;
                    output += string.Format("{0}", viceverse);
                   
                    abv /= 10;
                    
                }
                
            }
            while (imalicifrisledzapetaqta > 0 && numbers > 0)
            {
                viceverse = Convert.ToInt32(imalicifrisledzapetaqta);
                numbers = Convert.ToInt32(numbers);

                viceverse1 = Convert.ToInt32(numbers);
                viceverse %= 10;
                viceverse1 %= 10;
                if (viceverse > 0)
                {
                    output2 += string.Format("{0}", viceverse);
                }
                if (viceverse1 == 0)
                {
                    break;
                }
                output1 += string.Format("{0}", viceverse1);

                numbers /= 10;
                imalicifrisledzapetaqta /= 10;
            }
            string dot = ".";
            if (output2 == "")
            {
                return output;
            }
            else
            {
               return output = output2 + dot + output1;
            }
        }
    }
}
