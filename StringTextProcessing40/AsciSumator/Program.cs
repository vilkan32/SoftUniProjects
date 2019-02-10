using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciSumator
{
    class Program
    {
        static void Main(string[] args)
        {

            char a = char.Parse(Console.ReadLine());

            char b = char.Parse(Console.ReadLine());
            int sum = 0;
            string randomstring = Console.ReadLine();
            if (a < b)
            {
                foreach (var item in randomstring)
                {
                    if (item > a && item < b)
                    {
                        sum += item;
                    }
                }
            }
            else
            {
                foreach (var item in randomstring)
                {
                    if (item > b && item < a)
                    {
                        sum += item;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
