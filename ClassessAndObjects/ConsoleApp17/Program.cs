using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Catalog> Cataloga = new List<Catalog>();

            while (true)
            {
                string[] Input = Console.ReadLine().Split(' ').ToArray();
                if (Input[0] == "End")
                {
                    break;
                }

                Catalog catalog = new Catalog();

                catalog.Type = Input[0].ToLower();
                catalog.Model = Input[1];
                catalog.Color = Input[2];
                catalog.Horsepower = Input[3];
                Cataloga.Add(catalog);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Close the Catalogue")
                {
                    break;
                }

                foreach (var item in Cataloga)
                {
                    if (input == item.Model)
                    {
                        if (item.Type == "car")
                        {
                            Console.WriteLine("Type: Car");
                        }
                        else
                        {
                            Console.WriteLine("Type: Truck");
                        }
                        Console.WriteLine("Model: {0}", item.Model);
                        Console.WriteLine("Color: {0}", item.Color);
                        Console.WriteLine("Horsepower: {0}", item.Horsepower);
                        break;
                    }
                }

            }
            List<double> CarsHP = new List<double>();
            List<double> TruckHP = new List<double>();
            
            foreach (var item in Cataloga)
            {
                if (item.Type == "car")
                {
                    CarsHP.Add(Convert.ToInt32(item.Horsepower));

                }
                else
                {
                    TruckHP.Add(Convert.ToInt32(item.Horsepower));
                }
            }
            try
            {
                Console.WriteLine("Cars have average horsepower of: {0:f2}.", CarsHP.Average());
            }
            catch (Exception)
            {

                Console.WriteLine("Cars have average horsepower of: 0.00.");
            }
            try
            {
                Console.WriteLine("Trucks have average horsepower of: {0:f2}.", TruckHP.Average());
            }
            catch (Exception)
            {

                Console.WriteLine("Trucks have average horsepower of: 0.00.");
            }

        }
    }

    class Catalog
    {
       public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Horsepower { get; set; }


    }
}
