using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesLINQLambda
{
    class Program
    {
        static void Main(string[] args)
        {


            List<double> Input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            int counter = 0;

            List<double> singleNumbers = new List<double>();
            List<double> Counter = new List<double>();

            foreach (var item in Input)
            {

                if (singleNumbers.Contains(item))
                {
                    continue;
                }

                for (int i = 0; i < Input.Count; i++)
                {
                    if (Input[i] == item)
                    {
                        counter++;
                    }
                }
                if (counter != 0 && !singleNumbers.Contains(item))
                {
                    Counter.Add(counter);
                }
                counter = 0;

                if (singleNumbers.Contains(item))
                {

                }
                else
                {
                    singleNumbers.Add(item);
                }

            }

            int newcounter = 0;
            double[] OrederedNumbers = new double[singleNumbers.Count];
            foreach (var item in singleNumbers)
                {

                for (int i = 0; i < singleNumbers.Count; i++)
                {
                    if (item < singleNumbers[i])
                    {
                        newcounter++;
                    }
                }
                
                OrederedNumbers[singleNumbers.Count - newcounter - 1] = item;
                newcounter = 0;
            }

            
            for (int i = 0; i < OrederedNumbers.Length; i++)
            {
               int numberofoccurances = singleNumbers.IndexOf(OrederedNumbers[i]);
                Console.WriteLine("{0} -> {1}",OrederedNumbers[i], Counter[numberofoccurances]);

            }

        }
    }
}
