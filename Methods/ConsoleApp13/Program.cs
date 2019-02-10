using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double granica = double.Parse(Console.ReadLine());
            double last = double.Parse(Console.ReadLine());

            for (int i = 1; i < n ; i++)
            {
                double prices = double.Parse(Console.ReadLine());

                double razlika = Calculatetheprocentageofdifference(last, prices); 

                bool isSignificantDifference = ImaliDif(razlika, granica);



                string message = Get(prices, last, razlika, isSignificantDifference);
                Console.WriteLine(message);

                last = prices;
            }
        }

        private static string Get(double c, double last, double razlika, bool etherTrueOrFalse)
        {
            string output = "";
            if (razlika == 0)
            {
                output = string.Format("NO CHANGE: {0}", c);
            }
            else if (!etherTrueOrFalse)
            {
                output = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, razlika * 100);
            }
            else if (etherTrueOrFalse && (razlika > 0))
            {
                output = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, razlika * 100);
            }
            else if (etherTrueOrFalse && (razlika < 0))
                output = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, razlika * 100);
            return output;
        }
        private static bool ImaliDif(double granica, double isDiff)
        {
            if (Math.Abs(granica) >= isDiff)
            {
                return true;
            }
            return false;
        }

        private static double Calculatetheprocentageofdifference(double seconddigit, double firstdigit)
        {
            double difference = (firstdigit - seconddigit) / seconddigit;
            return difference;
        }

    }
    }

