using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<char> Digits = number.ToString().ToList();
            List<long> Result = new List<long>();
            long result = 0;


            for (int i = 0; i < Digits.Count(); i++)
            {
                int currentnumber = Convert.ToInt32(Digits[i].ToString());
                result = currentnumber;
                if (currentnumber <= 1)
                {
                    result = 1;
                }
                else
                {
                    for (int x = 1; x < currentnumber; x++)
                    {
                        result = result * x;
                    }
                }
                Result.Add(result);
            }


            if (Result.Sum() == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }



        }
    }
}
