using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            double TimeRacerOne = 0;
            for (int i = 0; i < Input.Count() / 2; i++)
            {
                if (Input[i] == 0)
                {
                    TimeRacerOne -= TimeRacerOne * 0.20;
                }
                else
                {
                    TimeRacerOne += Input[i];
                }
            }

            Input.Reverse();
            double TimeRacerTwo = 0;
            for (int i = 0; i < Input.Count() / 2; i++)
            {
                if (Input[i] == 0)
                {
                    TimeRacerTwo -= TimeRacerTwo * 0.20;
                }
                else
                {
                    TimeRacerTwo += Input[i];
                }
            }

            if (TimeRacerTwo > TimeRacerOne)
            {
                Console.WriteLine("The winner is left with total time: {0}", Math.Round(TimeRacerOne,1));
            }
            else
            {
                Console.WriteLine("The winner is right with total time: {0}", Math.Round(TimeRacerTwo, 1));
            }
        }
    }
}
