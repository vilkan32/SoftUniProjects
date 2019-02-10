using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> Regular = new HashSet<string>();

            while (true)
            {
                string guests = Console.ReadLine();

                if (guests == "PARTY")
                {
                    break;
                }
                if (guests[0] >= 48 && guests[0] <= 57)
                {
                    VIP.Add(guests);
                }
                else
                {
                    Regular.Add(guests);
                }

                
            }

            while (true)
            {
                string guests = Console.ReadLine();

                if (guests == "END")
                {
                    break;
                }

                if (guests[0] >= 48 && guests[0] <= 57)
                {
                    VIP.Remove(guests);
                }
                else
                {
                    Regular.Remove(guests);
                }
            }
            Console.WriteLine(VIP.Count + Regular.Count);
            if (VIP.Any())
            {
                Console.WriteLine(string.Join("\n", VIP));
            }
            if (Regular.Any())
            {
                Console.WriteLine(string.Join("\n", Regular));
            }
        }
    }
}
