using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> Result = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Person local = new Person();

                local.Name = input[0];
                local.Age = int.Parse(input[1]);
                Result.Add(local);
            }

            foreach (var item in Result.OrderByDescending(x => x.Age))
            {
                Console.WriteLine("{0} {1}", item.Name, item.Age);
                break;
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
