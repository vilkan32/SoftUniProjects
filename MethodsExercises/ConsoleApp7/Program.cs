using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            long read = long.Parse(Console.ReadLine());
            long read2 = long.Parse(Console.ReadLine());
            string numbers = String.Join(", ", FinPrimesInRange(read, read2).ToArray());
            Console.WriteLine(numbers);
        }

        static bool IsPrime(long n)

        {

            int SqrtN = (int)Math.Sqrt(n);

            if (n <= 1)
            {
                return false;
            }
            else if (n > 2)

            {
                for (int i = 2; i <= SqrtN; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }

                }
            }
            return true;
        }
        static List<long> FinPrimesInRange(long numberone, long numbertwo)
        {
            List<long> list = new List<long>();
            for (long i = numberone; i <= numbertwo; i++)
            {
                bool TrueorFalse = IsPrime(i);
                if (TrueorFalse)
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
