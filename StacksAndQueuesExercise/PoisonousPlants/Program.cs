using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PoisonousPlants
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<BigInteger> input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).Take(n).ToList();
            int counter = 0;
            while (true)
            {
                counter++;
                List<int> indextokill = new List<int>();
                for (int i = 1; i < input.Count; i++)
                {
                    if (input[i- 1] < input[i] )
                    {
                        indextokill.Add(i);
                    }

                }
                if (indextokill.Count == 0)
                {
                   
                    
                    Console.WriteLine(counter - 1);
                    break;
                }
                else
                {
                    List<BigInteger> NumsThatRemain = new List<BigInteger>();

                    for (int i = 0; i < input.Count; i++)
                    {
                        if (!indextokill.Contains(i))
                        {
                            NumsThatRemain.Add(input[i]);
                        }
                    }
                    input = NumsThatRemain;
                }
            }

        }
    }
}
