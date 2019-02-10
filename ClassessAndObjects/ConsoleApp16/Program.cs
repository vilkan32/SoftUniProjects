using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> People = new List<People>();

            while (true)
            {
                string input = Console.ReadLine();
                string[] Input = input.Split(' ').ToArray();
                if (input == "End")
                {
                    break;
                }

                People people = new People();
                people.Name = Input[0];
                people.ID = Input[1];
                people.Age = Convert.ToInt32(Input[2]);

                People.Add(people);



            }



            foreach (var item in People.OrderBy(x => x.Age))
            {
                Console.WriteLine("{0} with ID: {1} is {2} years old.", item.Name, item.ID, item.Age);
            }

        }
    }

    class People
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

    }
}
