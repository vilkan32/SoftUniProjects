using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {

            var cupCapacity = Console.ReadLine().Split(' ').Select(int.Parse);
            Queue<int> CupCapacity = new Queue<int>(cupCapacity);
            var bottles = Console.ReadLine().Split(' ').Select(int.Parse);
            Stack<int> Bottles = new Stack<int>(bottles);
            int wastedWater = 0;
            while (true)
            {
                if (CupCapacity.Any())
                {

                    if (Bottles.Any())
                    {
                        if (Bottles.Peek() - CupCapacity.Peek() >= 0)
                        {
                            wastedWater += Bottles.Pop() - CupCapacity.Dequeue();
                        }
                        else
                        {
                            int exchange = Math.Abs(Bottles.Pop() - CupCapacity.Dequeue());
                            CupCapacity = new Queue<int>(CupCapacity.Reverse());
                            CupCapacity.Enqueue(exchange);
                            CupCapacity = new Queue<int>(CupCapacity.Reverse());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Cups: {0}", string.Join(" ", CupCapacity));
                        Console.WriteLine("Wasted litters of water: {0}", wastedWater);
                        break;
                    }
                }
                else
                {
                    Bottles = new Stack<int>(Bottles.Reverse());
                    Console.WriteLine("Bottles: {0}", string.Join(" ", Bottles));
                    Console.WriteLine("Wasted litters of water: {0}", wastedWater);
                    break;
                }



            }


        }
    }
}
