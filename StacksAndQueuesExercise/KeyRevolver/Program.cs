using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {

            int bulletPrice = int.Parse(Console.ReadLine());

            int sizeBarrel = int.Parse(Console.ReadLine());

            var shots = Console.ReadLine().Split(' ').Select(int.Parse);

            Stack<int> Shots = new Stack<int>(shots);

            var locks = Console.ReadLine().Split(' ').Select(int.Parse);

            Queue<int> Locks = new Queue<int>(locks);

            int price = int.Parse(Console.ReadLine());
            int counter = 0;
            int shotscounter = 0;
            while (true)
            {
                if (Shots.Any())
                {
                    if (counter == sizeBarrel)
                    {
                        counter = 0;
                        Console.WriteLine("Reloading!");
                        continue;
                    }
                    if (Locks.Any())
                    {
                        if (Shots.Peek() <= Locks.Peek())
                        {
                            Console.WriteLine("Bang!");
                            counter++;
                            Shots.Pop();
                            Locks.Dequeue();
                            shotscounter++;
                        }
                        else
                        {
                            Console.WriteLine("Ping!");
                            counter++;
                            Shots.Pop();
                            shotscounter++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} bullets left. Earned ${1}", Shots.Count, price - (shotscounter * bulletPrice));
                        break;
                    }
                }
                else
                {
                    if (!Locks.Any() && !Shots.Any())
                    {
                        Console.WriteLine("{0} bullets left. Earned ${1}", Shots.Count, price - (shotscounter * bulletPrice));
                        break;
                    }
                    Console.WriteLine("Couldn't get through. Locks left: {0}", Locks.Count);
                    break;
                }
            }

        }
    }
}
