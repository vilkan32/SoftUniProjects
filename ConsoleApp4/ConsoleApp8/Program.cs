using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            var name = Console.ReadLine();

            int health = int.Parse(Console.ReadLine());

            int MaxHealth = int.Parse(Console.ReadLine());

            int energy = int.Parse(Console.ReadLine());

            int MaxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);

            Console.WriteLine("Health: |{0}{1}|", new string('|',health), new string('.', MaxHealth - health));

            Console.WriteLine("Energy: |{0}{1}|", new string('|', energy), new string('.', MaxEnergy - energy));

        }
    }
}
