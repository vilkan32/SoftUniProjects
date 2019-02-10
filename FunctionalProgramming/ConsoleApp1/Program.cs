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
            int[] nums = new int[3] { 3, 4, 5 };
            Func<int[], int> sum = x => Operation(nums);
            Console.WriteLine(sum);
            }
            public static int Operation(int[] n)
            {

            int result = 0;

            for (int i = 0; i < n.Length; i++)
            {
                result += n[i];
            }
            return result;
            }
    }
}
