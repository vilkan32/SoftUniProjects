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

            char firstboat = char.Parse(Console.ReadLine());

            char secondboat = char.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            int firstboatmovements = 0;

            int secondboatmovements = 0;

            for (int i = 1; i <= n; i++)
            {

                string read = Console.ReadLine();
                if (read == "UPGRADE")
                {
                   firstboat = Convert.ToChar(firstboat + 3);
                   secondboat = Convert.ToChar(secondboat + 3);
                    continue;
                   

                }
                if (i%2 == 0)
                {
                    secondboatmovements += read.Length;
                    if (secondboatmovements >= 50)
                    {
                        Console.WriteLine(secondboat);
                        break;
                    }

                    


                }
                else
                {
                    firstboatmovements += read.Length;
                    if (firstboatmovements >= 50)
                    {
                        Console.WriteLine(firstboat);
                        break;
                    }
                    
                }
            }
            if (firstboatmovements > secondboatmovements && firstboatmovements < 50 && secondboatmovements < 50)
            {
                Console.WriteLine(firstboat);
            }
            else if (secondboatmovements > firstboatmovements && secondboatmovements < 50 && firstboatmovements < 50)
            {
                Console.WriteLine(secondboat);
            }
            

        }
    }
}
