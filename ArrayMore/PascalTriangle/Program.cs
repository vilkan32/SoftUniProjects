using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<long> Subsequence = new List<long>();
            for (int i = 1; i <= n; i++)
            {
                long[] sequence = new long[i];

                sequence[0] = 1;
                if (sequence.Length > 1)
                {
                    sequence[sequence.Length - 1] = 1;
                    if (Subsequence.Count() != 0)
                    {
                        int counter = 1;
                        for (int y = 0; y < Subsequence.Count(); y++)
                        {
                            for (int z = counter; z < sequence.Length - 1;)
                            {
                                sequence[z] = Subsequence[y];
                                counter++;
                                break;
                            }
                        }
                        Subsequence = new List<long>();
                    }
                    for (int x = 0; x < sequence.Length - 1; x++)
                    {
                        long number = sequence[x] + sequence[x + 1];
                        Subsequence.Add(number);
                    }
                }
                Console.WriteLine(string.Join(" ", sequence));

            }
        }
    }
}
