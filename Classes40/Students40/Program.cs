using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students40
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            List<Student> Students = new List<Student>();
            for (int i = 0; i < a; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Student local = new Student();

                local.First = input[0];
                local.Last = input[1];
                local.Grade = double.Parse(input[2]);
                Students.Add(local);

            }

            foreach (var item in Students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine("{0} {1}: {2:f2}", item.First, item.Last, item.Grade);
            }
        }
    }
    class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public double Grade { get; set; }
    }
}

