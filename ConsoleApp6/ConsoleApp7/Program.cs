using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            int key = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            string word = "";

            for (int i = 1; i <= n; i++)
            {

                char letters = char.Parse(Console.ReadLine());

                int converted = letters + key;

                char output = Convert.ToChar(converted);

                word += output;
                

            }

            Console.WriteLine(word);
        }
    }
}
