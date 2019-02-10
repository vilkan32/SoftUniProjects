using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int HP = 100;
            int Coins = 0;

            List<string> Input = Console.ReadLine().Split(@"|").ToList();
            // ("item/monster number")
            bool killed = false;
            for (int i = 0; i < Input.Count(); i++)
            {
                string[] Room = Input[i].Split(' ').ToArray();
                if (Room[0] == "potion")
                {
                    
                    if (HP + int.Parse(Room[1]) > 100)
                    {
                        
                        Console.WriteLine("You healed for {0} hp.",100 - HP);
                        HP = 100;
                        Console.WriteLine("Current health: {0} hp.", HP);

                    }
                    else
                    {
                        Console.WriteLine("You healed for {0} hp.", int.Parse(Room[1]));
                        Console.WriteLine("Current health: {0} hp.", HP + int.Parse(Room[1]));
                        HP += int.Parse(Room[1]);
                    }
                }
                else if (Room[0] == "chest")
                {
                    Console.WriteLine("You found {0} coins.", Room[1]);
                    Coins += int.Parse(Room[1]);
                }
                else
                {
                    if (HP - int.Parse(Room[1]) > 0)
                    {
                        Console.WriteLine("You slayed {0}.", Room[0]);
                        HP -= int.Parse(Room[1]);
                    }
                    else
                    {
                        HP = 0;
                        Console.WriteLine("You died! Killed by {0}.",Room[0]);
                        Console.WriteLine("Best room: {0}", i + 1);
                        killed = true;
                        break;
                    }
                }
            }
            if (killed == false)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine("Coins: {0}", Coins);
                Console.WriteLine("Health: {0}", HP);
            }
        }
    }
}
