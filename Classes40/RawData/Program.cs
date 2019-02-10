using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            // "<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType>

            int n = int.Parse(Console.ReadLine());
            List<Car> Cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                Car local = new Car();
                local.Model = input[0];
                local.EngSpeed = int.Parse(input[1]);
                local.EngPower = int.Parse(input[2]);
                local.CargoWeight = int.Parse(input[3]);
                local.CargoType = input[4];
                Cars.Add(local);
            }
            string inp = Console.ReadLine();
            if (inp == "fragile")
            {
                foreach (var item in Cars.Where(x => x.CargoType == "fragile" && x.CargoWeight < 1000))
                {
                    Console.WriteLine(item.Model);
                }
            }
            else if (inp == "flamable")
            {
                foreach (var item in Cars.Where(x => x.CargoType == "flamable" && x.EngPower > 250))
                {
                    Console.WriteLine(item.Model);
                }
            }

        }
    }
    class Car
    {
        public string Model { get; set; }
        public int EngSpeed { get; set; }
        public int EngPower { get; set; }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}
