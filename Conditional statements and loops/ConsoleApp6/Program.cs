using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int preminavaniq = 0;

            for (int i = 0; i < n; i++)
            {
                preminavaniq += 1;
                for (int a = 1;a <= preminavaniq; a++)
                {
                    Console.Write("{0} ", preminavaniq);
                }
                Console.WriteLine();
            }
        }
    }
}
