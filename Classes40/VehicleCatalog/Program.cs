using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> Koli = new List<Car>();
            List<Trucks> Kamioni = new List<Trucks>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('/').ToArray();
                if (input[0] == "end")
                {
                    break;
                }
                if (input[0] == "Car")
                {
                    Car local = new Car();
                    local.Brand = input[1];
                    local.Model = input[2];
                    local.HP = input[3];
                    Koli.Add(local);
                }
                else if (input[0] == "Truck")
                {
                    Trucks local = new Trucks();
                    local.Brand = input[1];
                    local.Model = input[2];
                    local.Weight = input[3];
                    Kamioni.Add(local);
                }
            }

            if (Koli.Count() > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var item in Koli.OrderBy(x => x.Brand))
                {
                    Console.WriteLine("{0}: {1} - {2}hp", item.Brand, item.Model, item.HP);
                }
            }
            if (Kamioni.Count() > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var item in Kamioni.OrderBy(x => x.Brand))
                {
                    Console.WriteLine("{0}: {1} - {2}kg", item.Brand, item.Model, item.Weight);
                }
            }

        }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HP { get; set; }

    }
    class Trucks
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }
}
