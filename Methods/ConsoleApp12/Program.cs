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

            string stname = Console.ReadLine();

            int stgrade = int.Parse(Console.ReadLine());


            int stage = int.Parse(Console.ReadLine());

            PrintStudent(stname,stage,stgrade);

        }

        static void PrintStudent(string name, int age, int grade)

        {
            Console.WriteLine("Student: {0} Age{1}: {2} Grade ;", name ,age, grade);
        
        
        }
    }
}
