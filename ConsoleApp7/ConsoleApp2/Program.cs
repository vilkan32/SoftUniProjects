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
            var names = new List<string>(); // Create a list of strings

            names.Add("Peter");

            names.Add("Maria");

            names.Add("George");

            foreach (var name in names)

                Console.WriteLine(name);
            names.Remove("Maria");

            Console.WriteLine(

            String.Join(", ", names));
        }
    }
}
