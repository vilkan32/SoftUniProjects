using System;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            int[] conditions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Predicate<int> checker = x => Condition(conditions, x) == true;

            for (int i = 1; i <= range; i++)
            {
                if (checker(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static bool Condition(int[] some, int x)
        {
            bool passAll = true;
            for (int i = 0; i < some.Length; i++)
            {
                if (x % some[i] == 0)
                {

                }
                else
                {
                    passAll = false;
                    break;
                }
            }

            return passAll;

        }
    }
}
