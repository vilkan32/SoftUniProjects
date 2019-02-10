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
            string readtheinput = Console.ReadLine();
            int stringlenght = readtheinput.Length;
            Console.WriteLine(ReturnViceverse(stringlenght, readtheinput));
        }

        static string ReturnViceverse(int stringlength, string readthestring)
        
        {

            string output = "";

            for (int i = stringlength - 1; i >=0 ; i--)
            {
                output += readthestring[i];
            }
            return output;

        }
    }
}
