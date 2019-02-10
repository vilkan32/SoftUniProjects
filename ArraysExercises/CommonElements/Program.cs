using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> FirstLine = Console.ReadLine().Split(' ').ToList();

            List<string> SecondLine = Console.ReadLine().Split(' ').ToList();
            List<string> Output = new List<string>();

            for (int i = 0; i < SecondLine.Count(); i++)
            {
                if (FirstLine.Contains(SecondLine[i]))
                {
                    Output.Add(SecondLine[i]);
                }
            }

            Console.WriteLine(string.Join(" ", Output));
        }
    }
}
