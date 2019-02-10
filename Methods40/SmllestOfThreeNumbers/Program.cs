using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmllestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> ShowMeTheSmallest = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                int input = int.Parse(Console.ReadLine());
                ShowMeTheSmallest.Add(input);
            }


            Console.WriteLine(ShowMeTheSmallest.Min());


        }
    }
}
