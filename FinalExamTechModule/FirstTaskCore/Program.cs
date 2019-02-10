using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // band name - Dictionary<List>
            Dictionary<string, BandParticipants> Bands = new Dictionary<string, BandParticipants>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "start of concert")
                {
                    break;
                }
                string[] FirstPart = input.Split("; ").ToArray();

                if (FirstPart[0] == "Add")
                {
                    if (!Bands.ContainsKey(FirstPart[1]))
                    {

                        BandParticipants local = new BandParticipants();
                        string[] SecondPart = FirstPart[2].Split(", ");
                        local.BandPart = SecondPart.ToList();
                        local.TimePlay = 0;
                        Bands.Add(FirstPart[1], local);

                    }
                    else
                    {
                        BandParticipants local = new BandParticipants();
                        string[] SecondPart = FirstPart[2].Split(", ");

                        Bands[FirstPart[1]].BandPart.AddRange(SecondPart);
                    }
                }
                else if (FirstPart[0] == "Play")
                {
                    if (!Bands.ContainsKey(FirstPart[1]))
                    {

                        BandParticipants local = new BandParticipants();

                        local.BandPart = new List<string>();
                        local.TimePlay = int.Parse(FirstPart[2]);
                        Bands.Add(FirstPart[1], local);

                    }
                    else
                    {
                        Bands[FirstPart[1]].TimePlay += int.Parse(FirstPart[2]);
                    }
                }
            }

            var totaltime = 0;

            foreach (var item in Bands.Values)
            {
                totaltime += item.TimePlay;
            }
            Console.WriteLine($"Total time: {totaltime}");

            foreach (var item in Bands.OrderByDescending(x => x.Value.TimePlay).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.TimePlay}");
            }

            string bandzamake = Console.ReadLine();
            Console.WriteLine(bandzamake);
            foreach (var item in Bands[bandzamake].BandPart.Distinct())
            {
                Console.WriteLine($"=> {item}");

            }
        }
    }
    class BandParticipants
    {
        public List<string> BandPart { get; set; }
        public int TimePlay { get; set; }

    }
}
