using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            


            var list = Console.ReadLine().Split('|').ToList();
            var result = new List<string>();

            list.Reverse();

            foreach (var item in list)
            {
                List<string> nums = item.Split(' ').ToList();

                foreach (var num in nums)
                {
                    if (num != "")
                    {
                        result.Add(num);
                    }
                }
            }


            Console.WriteLine(String.Join(" ", result));






        }
    }
}
