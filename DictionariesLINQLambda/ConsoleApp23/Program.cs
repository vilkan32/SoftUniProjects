using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int immunestr = int.Parse(Console.ReadLine());

            int immuneSTR =  immunestr;
            List<string> virusnamelist = new List<string>();

            while (true)
            {
                int counter = 0;
                string virusname = Console.ReadLine();
                if (virusname == "end")
                {
                    Console.WriteLine("Final Health: {0}", immunestr);
                    break;
                   
                }
                int virusnameCount = virusname.Count();
                if (virusnamelist.Contains(virusname))
                {
                    counter++;
                }
                else
                {
                    virusnamelist.Add(virusname);
                }
                List<char> symbols = virusname.ToList();
                int Strength = 0;
                int Timetodefeat = 0;
                foreach (var symbol in symbols)
                {
                    Strength += Convert.ToUInt16(symbol);

                }

                Strength = Strength / 3;
                if (counter == 1)
                {
                    Timetodefeat = (Strength * virusnameCount) / 3;
                    counter = 0;
                }
                else
                {
                    Timetodefeat = Strength * virusnameCount;
                }
                Console.WriteLine("Virus {0}: {1} => {2} seconds", virusname, Strength, Timetodefeat);




                int remainingHP = immunestr - Timetodefeat;
                TimeSpan item = TimeSpan.FromSeconds(Timetodefeat);
                string output = string.Format("{0}m {1}s.", item.Minutes + item.Hours * 60 + item.Days * 24 *60 , item.Seconds);
                if ( remainingHP <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }
                else
                {
                    Console.WriteLine("{0} defeated in {1}m {2}s.", virusname, Timetodefeat/ 60, Timetodefeat - (Timetodefeat / 60) * 60);
                }
                Console.WriteLine("Remaining health: {0}", remainingHP);





                int regeneration = remainingHP * 20 / 100;
                if (regeneration + remainingHP >= immuneSTR && immunestr == immuneSTR)
                {
                    immunestr = immuneSTR;
                }
                else if (regeneration + remainingHP >= immunestr && regeneration + remainingHP < immuneSTR)
                {
                    immunestr = regeneration + remainingHP;
                }
                else if (regeneration + remainingHP >= immunestr && regeneration + remainingHP >= immuneSTR)
                {
                    immunestr = immuneSTR;
                }
                if (regeneration + remainingHP < immunestr)
                {
            
                    immunestr = regeneration + remainingHP;
                }

            }
        }
    }
}
