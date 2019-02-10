using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int obshto = 0;
            int currentnumber = 0;
            bool outputbool = false;
            for (int ch = 1; ch <= input; ch++)
            {
                currentnumber = ch;
                while (ch > 0)
                {
                    obshto += ch % 10;
                    ch = ch / 10;
                }
                outputbool = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine($"{currentnumber} -> {outputbool}");
                obshto = 0;
                ch = currentnumber;
            }



        }
    }
}
