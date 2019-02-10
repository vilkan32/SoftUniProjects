using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> CarPlates = new HashSet<string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "END")
                {
                    break;

                }
                if (command[0] == "IN")
                {
                    CarPlates.Add(command[1]);
                }

                if (command[0] == "OUT")
                {
                    CarPlates.Remove(command[1]);
                }


            }

            if (CarPlates.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(String.Join("\n", CarPlates));
            }
        }
    }
}
