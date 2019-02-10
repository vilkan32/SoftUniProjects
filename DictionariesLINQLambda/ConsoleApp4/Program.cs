using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Dictionary<int, int> newdict = new Dictionary<int, int>();

            Input = Input.OrderByDescending(x => x).Take(3).ToList();


            foreach (var item in Input)
            {
                Console.WriteLine(item);
            }
          

        }
    }
}
