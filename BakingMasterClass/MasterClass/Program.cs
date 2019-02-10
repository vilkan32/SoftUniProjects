using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> OneDayAsBaker = Console.ReadLine().Split('|').ToList();

            int energy = 100;
            int coins = 100;
            int success = 0;
            foreach (var item in OneDayAsBaker)
            {
                List<string> Commands = item.Split('-').ToList();

                if (Commands[0] == "rest")
                {
                    if (energy + Convert.ToInt32(Commands[1]) > 100)
                    {
                        int calculationone = ((energy + Convert.ToInt32(Commands[1])) - 100);

                        int addenergy = Convert.ToInt32(Commands[1]) - calculationone;
                        energy += addenergy;
                        Console.WriteLine("You gained {0} energy.", addenergy);
                        Console.WriteLine("Current energy: {0}.", energy);
                    }
                    else
                    {
                        energy += Convert.ToInt32(Commands[1]);
                        Console.WriteLine("You gained {0} energy.", Convert.ToInt32(Commands[1]));
                        Console.WriteLine("Current energy: {0}.", energy);
                    }
                }
                else if (Commands[0] == "order")
                {
                    if (energy - 30 >= 0)
                    {
                        Console.WriteLine("You earned {0} coins.", Convert.ToInt32(Commands[1]));
                        coins += Convert.ToInt32(Commands[1]);
                        energy -= 30;
                    }
                    else
                    {
                        Console.WriteLine("You had to rest!");
                        energy += 50;
                        success++;
                        continue;
                    }
                }
                else
                {
                    if (coins - Convert.ToInt32(Commands[1]) > 0)
                    {
                        Console.WriteLine("You bought {0}.", Commands[0]);
                        coins -= Convert.ToInt32(Commands[1]);
                    }
                    else
                    {
                        Console.WriteLine("Closed! Cannot afford {0}.", Commands[0]);
                        success++;
                        break;
                    }
                }
            }
            if (success == 0)
            {
                Console.WriteLine("Day completed!");
                Console.WriteLine("Coins: {0}", coins);
                Console.WriteLine("Energy: {0}", energy);
            }

        }
    }
}
