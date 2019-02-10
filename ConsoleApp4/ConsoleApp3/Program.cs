using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            Console.Write("{0:d4} ", first);

            Console.Write("{0:d4} ", second);
            Console.Write("{0:d4} ", third);
            Console.Write("{0:d4}", fourth);



        }
    }
}
