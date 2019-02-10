using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> Cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                Car local = new Car();
                local.Model = input[0];
                local.AmountF = double.Parse(input[1]);
                local.ConsumptionF = double.Parse(input[2]);
                Cars.Add(input[0], local);

            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "End")
                {
                    break;
                }

                
                if (Cars[input[1]].ConsumptionF * double.Parse(input[2]) <= Cars[input[1]].AmountF)
                {
                    Cars[input[1]].AmountF = Cars[input[1]].AmountF - Cars[input[1]].ConsumptionF * double.Parse(input[2]);
                    Cars[input[1]].TravelledD += double.Parse(input[2]);
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

            }

            foreach (var item in Cars)
            {
                Console.WriteLine("{0} {1:f2} {2}", item.Value.Model, item.Value.AmountF, item.Value.TravelledD);
            }
        }

    }
    class Car
    {
        public string Model { get; set; }

        public double AmountF { get; set; }

        public double ConsumptionF { get; set; }

        public double TravelledD { get; set; }
    }
}
