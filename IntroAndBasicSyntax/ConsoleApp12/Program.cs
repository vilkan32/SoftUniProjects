using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {

       
        
        static void Main(string[] args)
        {
            double lostgames = double.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());
            int timesheadset = 0;
            int timesmouse = 0;
            int timeskeyboard = 0;
            int timesdisplay = 0;
            int curr = 0;
            double output = 0;
            int counter = 0;
            for (int i = 1; i <= (int)lostgames; i++)
            {
                if (i % 2 == 0)
                {
                    timesheadset++;
                    curr++;
                }
                if (i % 3 == 0)
                {
                    if (curr == 1)
                    {
                        curr++;
                    }
                    timesmouse++;
                }

                if (curr == 2)
                {
                    timeskeyboard++;
                    counter++;
                    curr = 0;
                }
                else
                {
                    curr = 0;
                }

                if (counter % 2 ==0 && counter != 0)
                {
                    timesdisplay++;
                    counter = 0;
                }
            }

            output = timesmouse * mouse + timeskeyboard * keyboard + timesheadset * headset + timesdisplay * display;

            Console.WriteLine("Rage expenses: {0:f2} lv.", output);

      
        }
    }
}
