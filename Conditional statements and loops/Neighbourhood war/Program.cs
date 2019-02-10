using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbourhood_war
{
    class Program
    {
        static void Main(string[] args)
        {
            int Peshodmg = int.Parse(Console.ReadLine()); // first to attack

            int Goshodmg = int.Parse(Console.ReadLine());

            int Peshohealth = 100;

            int Goshohealth = 100;

            int numberofrounds = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 > 0)
                {
                    numberofrounds++;
                    Goshohealth -= Peshodmg;
                    if (Goshohealth <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", numberofrounds);
                        break;
                    }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", Goshohealth);
                  
                    if (numberofrounds % 3 == 0)
                    {
                        Goshohealth += 10;
                        Peshohealth += 10;
                    }
                    
                }
             
                else if (i % 2 == 0)
                {
                    numberofrounds++;
                   
                    Peshohealth -= Goshodmg;
                    if (Peshohealth <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", numberofrounds);
                        break;
                    }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", Peshohealth);

                    if (numberofrounds % 3 == 0)
                    {
                        Goshohealth += 10;
                        Peshohealth += 10;
                    }

                }
               



            }





        }
    }
}
