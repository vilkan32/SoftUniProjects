using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Person> set = new List<Person>();
            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var createPerson = new Person();

                createPerson.Name = input[0];
                createPerson.Age = int.Parse(input[1]);

                set.Add(createPerson);

            }

            string condition = Console.ReadLine();
            int ageCondition = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var result = set.Where(Condition(condition, ageCondition)).ToList();

            result.ForEach(WriteOntheConsole(format));


            

        }

        public static Func<Person, bool> Condition(string cond, int age)
        {
            if (cond == "younger")
            {
                return x => x.Age < age;
            }
            else
            {
                return x => x.Age >= age;
            }
        }

        public static Action<Person> WriteOntheConsole(string[] format)
        {
            if (format.Length == 1 && format[0] == "name")
            {
                return x => Console.WriteLine(x.Name);
            }
            if (format.Length == 1 && format[0] == "age")
            {
                return x => Console.WriteLine(x.Age);
            }
            else
            {
                return x => Console.WriteLine(x.Name + " - " + x.Age);
            }

        }

        public class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }


        }
    }
}
