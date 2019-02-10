using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int counter = 0;
            for (int i = 0; i < Input.Count(); i++)
            {
                int leftsum = 0;
                int rightsum = 0;
               
                for (int x = i + 1; x < Input.Count(); x++)
                {
                    rightsum += Input[x];
                }

                for (int y = 0; y < i; y++)
                {
                    if (i == 0)
                    {
                        break;
                    }
                    else
                    {
                        leftsum += Input[y];
                    }
                }

                if (leftsum == rightsum)
                {
                    counter++;
                    Console.WriteLine(i);
                    break;
                }

            }
            if (counter == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}
