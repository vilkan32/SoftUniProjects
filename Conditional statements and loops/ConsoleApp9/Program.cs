using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)

        {

        double currentbalance = double.Parse(Console.ReadLine());

        

            double roverorigina = 39.99d;
            double availablemoney = currentbalance;




            for (int i = 1; i <= 100; i++)
            {
                string gamename = Console.ReadLine();
                if (gamename == "Game Time" && availablemoney > 0)
                {
                    Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", currentbalance - availablemoney,availablemoney);
                    break;
                }
                else if (gamename == "Game Time" && availablemoney == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                else if (gamename == "OutFall 4")
                {
                    Math.Round(availablemoney -= 39.99,2);
                    if (availablemoney  <0)
                    {
                        Console.WriteLine("Too Expensive");
                        availablemoney += 39.99;
                        continue;
                    }
                    else if (availablemoney == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    Console.WriteLine("Bought OutFall 4");

                }
                else if (gamename == "CS: OG")
                {
                    availablemoney -= 15.99;
                    if (availablemoney < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        availablemoney += 15.99;
                        continue;
                    }
                    else if (availablemoney == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    Console.WriteLine("Bought CS: OG");
                }
                else if (gamename == "Zplinter Zell")
                {
                    Math.Round(availablemoney -= 19.99,2);
                    if (availablemoney < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        availablemoney += 19.99;
                        continue;
                    }
                    else if (availablemoney == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    Console.WriteLine("Bought Zplinter Zell");
                }
                else if (gamename == "Honored 2")
                {
                    availablemoney -= 59.99;
                    if (availablemoney < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        availablemoney += 59.99;
                        continue;
                    }
                    else if (availablemoney == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    Console.WriteLine("Bought Honored 2");
                }
                else if (gamename == "RoverWatch")
                {
                    availablemoney -= 29.99;
                    if (availablemoney < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        availablemoney += 29.99;
                        continue;
                    }
                    else if (availablemoney == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    Console.WriteLine("Bought RoverWatch");
                }
                else if (gamename == "RoverWatch Origins Edition")
                {
                    Math.Round(availablemoney -= roverorigina,2);
                    if (availablemoney < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        availablemoney += 39.99;
                        continue;
                    }
                    else if (availablemoney == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    Console.WriteLine("Bought RoverWatch Origins Edition");
                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }
            }





        }
    }
}
