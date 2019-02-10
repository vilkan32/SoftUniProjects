using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonaciSequence
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());

            List<int> Tribonacci = new List<int>();
            Tribonacci.Add(0);
            Tribonacci.Add(0);
            Tribonacci.Add(1);
            int mastotonaindexa = 3;
            int startanaindexa = 0;
            while (true)
            {
                if (a == 1)
                {
                    break;
                }
                int addSum = 0;
                for (int i = startanaindexa; i < mastotonaindexa; i++)
                {
                    addSum += Tribonacci[i];
                }
                Tribonacci.Add(addSum);
                mastotonaindexa++;
                startanaindexa++;
                a--;
            }

            for (int i = 2; i < Tribonacci.Count(); i++)
            {
                Console.Write(Tribonacci[i]+ " ");
            }
            Console.WriteLine();
        }
    }
}
