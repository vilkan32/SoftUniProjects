using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] price = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int priceofthejewels = price[0];

            int priceofthegold = price[1];

            int counterofgold = 0;
            int counterofJewels = 0;
            int totalearnings = 0;

            int HeistTotal = 0;

            while (true)
            {
                string[] LootHeist = Console.ReadLine().Split(' ').ToArray();

                char[] characters = LootHeist[0].ToArray();
                int HeistExpenses = 0;
                try
                {
                   HeistExpenses = Convert.ToInt32(LootHeist[1]);
                }
                catch (Exception)
                {

                    break;
                }
                for (int i = 0; i < characters.Length; i++)
                {
                    if (characters[i] == '%')
                    {
                        counterofJewels++;
                    }
                    else if (characters[i] == '$')
                    {
                        counterofgold++;
                    }

                }
                HeistTotal += HeistExpenses;
                

            }

            totalearnings = (counterofJewels * priceofthejewels) + (counterofgold * priceofthegold);
            if (totalearnings >= HeistTotal)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.",totalearnings - HeistTotal);
            }
            else
            {
                Console.WriteLine("Have to find another job. Lost: {0}.", HeistTotal - totalearnings);
            }

        }
    }
}
