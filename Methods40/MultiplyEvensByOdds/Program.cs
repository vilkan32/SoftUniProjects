using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string rewrite = "";
            foreach (var item in input)
            {
                try
                {
                    rewrite += Convert.ToInt32(item.ToString());
                }
                catch (Exception)
                {

                  
                }
            }

            long oddsum = 0;
            long evensum = 0;
            int[] listofdigits = new int[rewrite.Length];
            for (int i = 0; i < rewrite.Length; i++)
            {
                listofdigits[i] = Convert.ToInt32(rewrite[i].ToString());

            }

            foreach (var item in listofdigits.Where(a => a % 2 == 0))
            {
                evensum += item;
            }
            foreach (var item in listofdigits.Where(a => a % 2 != 0))
            {
                oddsum += item; 
            }
            Console.WriteLine(oddsum * evensum);
        }
    }
}
