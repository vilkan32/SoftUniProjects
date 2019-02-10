using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, List<int>>> SortedDragonsbyType = new Dictionary<string, SortedDictionary<string, List<int>>>();

            for (int i = 1; i <= a; i++)
            {
                string input = Console.ReadLine();

                List<string> Input = input.Split(' ').ToList();

                string type = Input[0];
                string name = Input[1];
                int damage = 0;
                int health = 0;
                int armor = 0;
                try
                {
                     damage = Convert.ToInt32(Input[2]);
                }
                catch (Exception)
                {
                    damage = 45;
                    
                }
                try
                {
                    health = Convert.ToInt32(Input[3]);
                }
                catch (Exception)
                {
                    health = 250;

                }
                try
                {
                    armor = Convert.ToInt32(Input[4]);
                }
                catch (Exception)
                {

                    armor = 10;

                }

                if (!SortedDragonsbyType.ContainsKey(type))
                {
                    SortedDragonsbyType.Add(type, new SortedDictionary<string, List<int>>());
                }
                if (!SortedDragonsbyType[type].ContainsKey(name))
                {
                    SortedDragonsbyType[type].Add(name, new List<int>());
                    SortedDragonsbyType[type][name].Add(damage);
                    SortedDragonsbyType[type][name].Add(health);
                    SortedDragonsbyType[type][name].Add(armor);
                }
                else
                {
                    SortedDragonsbyType[type][name][0] = damage;
                    SortedDragonsbyType[type][name][1] = health;
                    SortedDragonsbyType[type][name][2] = armor;
                }


            }

            foreach (var item in SortedDragonsbyType)
            {
                double averagedamage = 0;
                double avegarehealth = 0;
                double averagearmor = 0;
                int currnetdamage = 0;
                int currenthealth = 0;
                int currentarmor = 0;
                int counter = 0;
                foreach (var items in item.Value)
                {
                   averagedamage += Convert.ToDouble(items.Value[0]);
                   avegarehealth += Convert.ToDouble(items.Value[1]);
                   averagearmor += Convert.ToDouble(items.Value[2]);
                    counter++;
                }
                averagedamage = Math.Round(averagedamage / counter, 2);
                averagearmor = Math.Round(averagearmor / counter, 2);
                avegarehealth = Math.Round(avegarehealth / counter, 2);
                Console.WriteLine("{0:d2}::({1:f2}/{2:f2}/{3:f2})", item.Key, averagedamage, avegarehealth, averagearmor);
                foreach (var items1 in item.Value)
                {
                    currnetdamage = items1.Value[0];
                    currenthealth = items1.Value[1];
                    currentarmor = items1.Value[2];
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", items1.Key, currnetdamage,currenthealth,currentarmor);
                }
                
           
            }

        }
    }
}
