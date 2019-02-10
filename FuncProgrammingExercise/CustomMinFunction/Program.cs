using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Func<List<int>, int> minNum = x => x.Min();
            
            Console.WriteLine(minNum(nums));
        }

        public static int ReturnMin(List<int> nums)
        {

            int result = nums[0];

            foreach (var item in nums)
            {
                if (item < result)
                {
                    result = item;
                }
            }

            return result;
        }
    }
}
