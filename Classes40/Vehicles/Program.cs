using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            // {typeOfVehicle} {model} {color} {horsepower}
            List<Vehicles> Catalog = new List<Vehicles>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "End")
                {
                    break;
                }
                Vehicles local = new Vehicles();
                if (input[0].ToLower() == "car")
                {
                    local.Type = "Car";
                }
                else if (input[0].ToLower() == "truck")
                {
                    local.Type = "Truck";
                }
               
                local.Model = input[1];
                local.Color = input[2];
                local.HP = int.Parse(input[3]);
                Catalog.Add(local);

            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Close the Catalogue")
                {
                    break;
                }
                else
                {
                    foreach (var item in Catalog.Where(x => x.Model == input))
                    {
                        Console.WriteLine("Type: {0}", item.Type);
                        Console.WriteLine("Model: {0}", item.Model);
                        Console.WriteLine("Color: {0}", item.Color);
                        Console.WriteLine("Horsepower: {0}", item.HP);
                    }
                }
            }
            double TotalHP = 0;
            int totalcars = 0;
            foreach (var item in Catalog.Where(x => x.Type == "Car"))
            {
                TotalHP += item.HP;
                totalcars++;
            }
            double TotalHPtr = 0;
            int totaltr = 0;
            foreach (var item in Catalog.Where(x => x.Type == "Truck"))
            {
                TotalHPtr += item.HP;
                totaltr++;
            }
            if (totalcars != 0)
            {
                Console.WriteLine("Cars have average horsepower of: {0:f2}.", TotalHP / totalcars);
            }
            if (totaltr != 0)
            {
                Console.WriteLine("Trucks have average horsepower of: {0:f2}.", TotalHPtr / totaltr);

            }
        }
    }
    class Vehicles
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HP { get; set; }
    }
}
