using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double a = Convert.ToDouble(N) * 0.5;
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int pokedtargets = 0;

            while (true)
            {
                if (N < M)
                {
                    break;
                }
                if (N == a)
                {
                    if (Y != 0)
                    {
                        N = N / Y;
                    }
                    if (N < M)
                    {
                        break;
                    }
                }
                N -= M;
                pokedtargets++;
                if (N < M)
                {
                    break;
                }
            }

            Console.WriteLine(N);
            Console.WriteLine(pokedtargets);
        }
    }
}
