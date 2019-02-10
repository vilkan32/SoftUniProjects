using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {

            double savings = double.Parse(Console.ReadLine());
            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> Cloned = new List<int>();
            for (int i = 0; i < Input.Count(); i++)
            {
                Cloned.Add(Input[i]);
            }
            while (true)
            {
                string power = Console.ReadLine();

                if (power == "Hit it again, Gabsy!")
                {
                    Console.WriteLine(string.Join(" ", Input));
                    Console.WriteLine("Gabsy has {0:f2}lv.", savings);
                    break;
                }
                int Power = int.Parse(power);
                for (int i = 0; i < Input.Count(); i++)
                {
                    if (Input[i] - Power > 0)
                    {
                        Input[i] -= Power;
                    }
                    else
                    {
                        if (savings - Cloned[i] * 3 > 0)
                        {
                            savings -= Cloned[i] * 3;
                            Input[i] = Cloned[i];
                        }
                        else
                        {
                            Input.RemoveAt(i);
                            Cloned.RemoveAt(i);
                            i -= 1;
                        }
                    }
                }         
            }
        }
    }
}
