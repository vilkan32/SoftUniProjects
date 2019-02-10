using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());

            double[] ListofNumbers = new double[a];


            for (int i = 0; i < ListofNumbers.Length; i++)
            {
                a = int.Parse(Console.ReadLine());

                ListofNumbers[i] = a;
            }


            Dictionary<string, double> Output = new Dictionary<string, double>();

            Output["Sum"] = ListofNumbers.Sum();
            Output["Min"] = ListofNumbers.Min();
            Output["Max"] = ListofNumbers.Max();
            Output["Average"] = ListofNumbers.Average();

            foreach (KeyValuePair<string, double> output in Output)
            {
                Console.WriteLine(output.Key+" = "+ output.Value);
            }


        }
    }
}
