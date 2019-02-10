using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> que = new Queue<string>();

            while (true)
            {
                string NameOrCommand = Console.ReadLine();

                if (NameOrCommand == "End")
                {
                    break;
                }
                else if (NameOrCommand == "Paid")
                {
                    while (que.Any())
                    {
                        Console.WriteLine(que.Dequeue());
                    }
                }
                else
                {
                    que.Enqueue(NameOrCommand);

                }
            }

            Console.WriteLine("{0} people remaining.", que.Count);
        }
    }
}
