using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            int beatspermin = int.Parse(Console.ReadLine());

            double beats = double.Parse(Console.ReadLine());
            var bars = beats / 4;
            var min = beats / beatspermin;
            var sec = (min * 60) % 60;
            Console.WriteLine("{0} bars - {1}m {2}s", Math.Round(bars, 1), Math.Floor(min), Math.Floor(sec));
        }
    }
    }

