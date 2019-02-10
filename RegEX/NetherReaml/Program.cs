using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NetherReaml
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Demons = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<Demon> Hell = new List<Demon>();
            foreach (var item in Demons.OrderBy(x => x))
            {
                var DemonHP = 0;
                // Regex.Matches(item, @"[^0-9-.\/*+]").Cast<Match>().Select(x => Convert.ToInt32(x.Value[0])).ToArray().Sum();
                foreach (var set in item)
                {
                    if (set != '0' && set != '1' && set != '2' && set != '3' && set != '4' && set != '5' && set != '6'&& set != '7' && set != '8' && set != '9' && set != '-' && set != '.' && set != '/' && set != '*' && set != '+')
                    {
                        DemonHP += Convert.ToInt32(set);
                    }
                }

                var Digits = Regex.Matches(item, @"[+-]?\d+(\.\d+)?").Cast<Match>().Select(x => double.Parse(x.Value)).ToList().Sum();

               

                foreach (var symbol in item)
                {
                    if (symbol == '/')
                    {
                        Digits /= 2;
                    }
                    else if (symbol == '*')
                    {
                        Digits *= 2;
                    }
                }

                Demon local = new Demon();
                local.Name = item;
                local.Health = DemonHP;
                local.Damage = Digits;
                Hell.Add(local);

            }

            foreach (var item in Hell)
            {
                Console.WriteLine("{0} - {1} health, {2:f2} damage", item.Name, item.Health, item.Damage);
            }

        }
    }
    class Demon
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }
    }

}
