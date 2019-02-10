using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> Parking = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                List<string> Input = Console.ReadLine().Split(' ').ToList();

                if (Input[0] == "register")
                {
                    if (Parking.ContainsKey(Input[1]))
                    {
                        Console.WriteLine("ERROR: already registered with plate number {0}", Parking[Input[1]]);
                    }
                    else
                    {
                        Console.WriteLine("{0} registered {1} successfully", Input[1], Input[2]);
                        Parking.Add(Input[1], Input[2]);
                        
                    }
                }
                else if (Input[0] == "unregister")
                {
                    if (!Parking.ContainsKey(Input[1]))
                    {
                        Console.WriteLine("ERROR: user {0} not found", Input[1]);
                    }
                    else
                    {
                        Console.WriteLine("{0} unregistered successfully", Input[1]);
                        Parking.Remove(Input[1]);
                    }
                }
            }
            foreach (var item in Parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
