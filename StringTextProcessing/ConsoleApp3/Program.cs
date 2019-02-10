using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

          List<string>Input = Console.ReadLine().Split(' ').ToList();
            string Number = Input[1];
            List<char> numbers = Number.ToList();
            List<BigInteger> Output = new List<BigInteger>();
            numbers.Reverse();
            BigInteger result1 = 0;
            for (int i = 0; i < numbers.Count(); i++)
            {
              
                result1 += Convert.ToInt64(numbers[i].ToString()) * ReturnPow(Convert.ToInt32(Input[0]), i);

            }
            Console.WriteLine(result1);
            

        }
        public static BigInteger ReturnPow(int a, int b)
        {
            BigInteger Result = a;

            for (int i = 1; i < b; i++)
            {
                Result *= a;
            }
            if (b == 0)
            {
                return 1;
            }
            else
            {
                return Result;
            }
        }
   
    }
}
