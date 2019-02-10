using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            while (true)
            {               

                string[] command = Console.ReadLine().Split(' ');
                if (command[0] == "No" && command[1] == "more" && command[2] == "tires")
                {
                    break;
                }
                else
                {
                    var guma = new Tire[4];
                    guma[0] = new Tire(int.Parse(command[0]), double.Parse(command[1]));
                    guma[1] = new Tire(int.Parse(command[2]), double.Parse(command[3]));
                    guma[2] = new Tire(int.Parse(command[4]), double.Parse(command[5]));
                    guma[3] = new Tire(int.Parse(command[6]), double.Parse(command[7]));

                    tires.Add(guma);
                }
            }

            while (true)
            {

                string[] command = Console.ReadLine().Split(' ');
                if (command[0] == "Engines" && command[1] == "done")
                {
                    break;
                }
                else
                {
                    engines.Add(new Engine(int.Parse(command[0]), double.Parse(command[1])));
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[0] == "Show" && command[1] == "special")
                {
                    break;
                }
                else
                {
                    cars.Add(new Car(command[0], command[1], int.Parse(command[2]), double.Parse(command[3]), double.Parse(command[4]), engines[int.Parse(command[5])], tires[int.Parse(command[6])]));
                }
            }

            var result = cars.Where(x => x.Year >= 2017)
                .Where(x => x.Engine.HorsePower > 330)
                .Where(x => x.Tires.Select(y => y.Pressure).Sum() >= 9 && x.Tires.Select(y => y.Pressure).Sum() <=10).ToList();

            foreach (var item in result)
            {
                item.Drive(20);
                Console.WriteLine($"Make: {item.Make}");
                Console.WriteLine($"Model: {item.Model}");
                Console.WriteLine($"Year: {item.Year}");
                Console.WriteLine($"HorsePowers: {item.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {item.FuelQuantity}");
            }
        }
    }
}
