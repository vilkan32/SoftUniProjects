using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            int ID = int.Parse(Console.ReadLine());

            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);

            Console.WriteLine("Age: {0}", age);

            Console.WriteLine("Employee ID: {0:d8}", ID);

            Console.WriteLine("Salary: {0:f2}", salary);
            
            
            }
    }
}
