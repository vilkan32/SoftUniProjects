using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintHeader();
            PrintBody();
            PrintBottom();






        }

        static void PrintHeader()
        {

            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");

        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
            Console.WriteLine("------------------------------");
        }

        static void PrintBottom()
        {
            Console.WriteLine("\u00A9 SoftUni");

        }
    }
}
