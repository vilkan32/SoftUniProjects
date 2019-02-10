using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> Input = Console.ReadLine().ToList();
            string output = "";
            for (int i = 0; i < Input.Count(); i++)
            {
               output = "\\u" + ((int)Input[i]).ToString("X4").ToLower();
                Console.Write(output);
            }

            
            List<IEnumerable<int>> Test = new List<IEnumerable<int>>();

            Test.Add(Enumerable.Range(1, 10));
        }
    }
}
