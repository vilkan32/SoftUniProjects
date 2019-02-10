using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());
            string output = "";
            for (int i = 0; i < Input.Count(); i++)
            {
                int number = Input[i];


                for (int x = i + 1; x < Input.Count(); x++)
                {
                    if (number + Input[x] == n)
                    {
                        output += number + " " + Input[x] + "\r\n";
                    }
                }
            }

            Console.WriteLine(output.TrimEnd());
        }
    }
}
