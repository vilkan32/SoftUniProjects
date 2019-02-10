using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            double formula = 0;
            double previousnum = 0;
            int lines = int.Parse(Console.ReadLine());
            string nameofthekeg = "";

            for (int i = 1; i <= lines; i++)
            {
                string model = Console.ReadLine();

                double radius = double.Parse(Console.ReadLine());

                double height = double.Parse(Console.ReadLine());

              
                
                formula = Math.PI * radius * radius * height;
                if (formula > previousnum)
                {
                    previousnum = formula;
                    nameofthekeg = model;
                }
            }


            Console.WriteLine(nameofthekeg);




        }
    }
}
