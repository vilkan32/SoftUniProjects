using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {


            int condition = int.Parse(Console.ReadLine());

            Func<string, char[]> funcToChar = x => x.ToCharArray();
            Func<char, int> castFunc = y => (int)y;
            Func<string, bool> finalFunc = x => funcToChar(x).Select(castFunc).Sum() >= condition;

            Console.WriteLine(Console.ReadLine().Split().FirstOrDefault(finalFunc));


        }
    }
}
