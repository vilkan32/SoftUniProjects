using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSequenceQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            long n = long.Parse(Console.ReadLine());

            long S = n;
            var sequence = new Queue<long>();
            int count = 0;
            for (int i = 0; i < 17; i++)
            {
                sequence.Enqueue(S + 1);
                sequence.Enqueue(2 * S + 1);
                sequence.Enqueue(S + 2);
                S = sequence.ElementAt(count);
                count++;
            }
            Console.Write(n+ " ");
            for (int i = 0; i < 49; i++)
            {
                Console.Write("{0} ", sequence.Dequeue());
            }

        }
    }
}
