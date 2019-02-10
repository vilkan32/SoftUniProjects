using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {



            List<int> FirstPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            List<int> SecondPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {

                if (FirstPlayer.Count() == 0)
                {
                    Console.WriteLine("Second player wins! Sum: {0}", SecondPlayer.Sum());
                    break;
                }
                else if (SecondPlayer.Count() == 0)
                {
                    Console.WriteLine("First player wins! Sum: {0}", FirstPlayer.Sum());
                    break;
                }

                if (FirstPlayer[0] < SecondPlayer[0])
                {
                    
                    SecondPlayer.Add(SecondPlayer[0]);
                    SecondPlayer.Add(FirstPlayer[0]);
                    FirstPlayer.RemoveAt(0);
                    SecondPlayer.RemoveAt(0);
                }
                else if (FirstPlayer[0] > SecondPlayer[0])
                {
                    FirstPlayer.Add(FirstPlayer[0]);
                    FirstPlayer.Add(SecondPlayer[0]);
                    FirstPlayer.RemoveAt(0);
                    SecondPlayer.RemoveAt(0);
                }
                else if (FirstPlayer[0] == SecondPlayer[0])
                {
                    FirstPlayer.RemoveAt(0);
                    SecondPlayer.RemoveAt(0);
                }
            }

        }
    }
}
