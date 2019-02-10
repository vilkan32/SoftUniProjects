using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            List<string> OutputFormat = new List<string>();
            List<BigInteger> SnowballValue = new List<BigInteger>();
            for (int i = 0; i < a; i++)
            {
                BigInteger snowballSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballTime = BigInteger.Parse(Console.ReadLine());

                BigInteger snowballQuality = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballValue = RaisePower((snowballSnow / snowballTime), snowballQuality);
               
                string outputformat = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
              
                if (snowballQuality == 0)
                {
                     outputformat = $"{snowballSnow} : {snowballTime} = 1 ({snowballQuality})";
                }
                OutputFormat.Add(outputformat);
                SnowballValue.Add(snowballValue);

            }

            Console.WriteLine(OutputFormat[SnowballValue.IndexOf(SnowballValue.Max())]);
        }

        public static BigInteger RaisePower(BigInteger basis, BigInteger power)
        {
            BigInteger sum = basis;
            for (int i = 0; i < power - 1; i++)
            {
                sum *= basis;
            }
            return sum;
        }
    }
}
