using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> FirstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> SecondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int a = 0;
            int b = 0;

            if (FirstList.Count() > SecondList.Count())
            {
                a = FirstList[FirstList.Count() - 1];
                b = FirstList[FirstList.Count() - 2];
                FirstList.RemoveAt(FirstList.Count() - 1);
                FirstList.RemoveAt(FirstList.Count() - 1);

            }
            else
            {
                a = SecondList[0];
                b = SecondList[1];
                SecondList.RemoveAt(0);
                SecondList.RemoveAt(0);
            }
            List<int> Mix = new List<int>();
            SecondList.Reverse();
            for (int i = 0; i < SecondList.Count(); i++)
            {
                Mix.Add(FirstList[i]);
                Mix.Add(SecondList[i]);
            }
            List<int> Sorted = new List<int>();
            foreach (var item in Mix)
            {
                if (item > Math.Min(a,b) && item < Math.Max(a,b))
                {
                    Sorted.Add(item);
                }
            }

            Sorted.Sort();

            Console.WriteLine(string.Join(" ", Sorted));
        }
    }
}
