using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal Partysize = decimal.Parse(Console.ReadLine());

             decimal Days = decimal.Parse(Console.ReadLine());

            // Every day, you are earning 50 coins, but you also spent 2 coin per companion for food. 

            //   Every 3rd(third) day, you have a motivational party, spending 3 coins per companion for drinking water. 
            //Every 5th (fifth) day you slay a boss monster and you gain 20 coins per companion. But if you have a motivational party the same day, you spent additional 2 coins per companion
            // Every 10th (tenth) day at the start of the day, 2 (two) of your companions leave, but every 15th (fifteenth) day 5 (five) new companions are joined at the beginning of the day.
            // You have to calculate how much coins gets each companion at the end of the adventure.

            decimal coins = 0;

            for (int i = 1; i <= Days; i++)
            {
                if (i % 10 == 0)
                {
                    Partysize -= 2;
                }
                if (i % 15 == 0)
                {
                    Partysize += 5;
                }
                if (i % 3 == 0)
                {
                    coins -= 3 * Partysize;
                }
                if (i % 5 == 0)
                {
                    coins += 20 * Partysize;
                    if (i % 3 == 0)
                    {
                        coins -= 2 * Partysize;
                    }
                }
                coins += 50;
                coins -= Partysize * 2;
            }

            Console.WriteLine("{0} companions received {1} coins each.", Partysize, Math.Floor(coins / Partysize));
        }
    }
}
