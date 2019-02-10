using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Test = new List<Student>();
            

            while (true)
            {
                Student test = new Student();
                string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }).ToArray();

                if (input[0] == "end" && input[1] == "of" && input[2] == "dates")
                {
                    break;
                }
                string username = input[0];
                List<DateTime> date = new List<DateTime>();
                List<string> comments = new List<string>();
                string format = "dd/MM/yyyy";
                for (int i = 1; i < input.Length; i++)
                {
                    date.Add(DateTime.ParseExact(input[i], format, System.Globalization.CultureInfo.InvariantCulture));
                }
                int counter = 0;
                for (int i = 0; i < Test.Count; i++)
                {
                    if (Test[i].Username == username)
                    {
                        Test[i].Dates.AddRange(date);
                        counter++;
                        break;
                    }
                }
                if (counter == 0)
                {
                    test.Dates = new List<DateTime>();
                    test.Dates = date;
                    test.Username = username;
                    test.Comments = comments;
                    Test.Add(test);
                }
                
                
                    
                
           
                
            }
            while (true)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();
                if (input[0] == "end of comments")
                {
                    break;
                }
                for (int i = 0; i < Test.Count(); i++)
                {
                    if (Test[i].Username == input[0])
                    {
                        Test[i].Comments.Add(input[1]);
                    }
                }

            }

            foreach (var item in Test.OrderBy(x => x.Username))
            {
                Console.WriteLine("{0}", item.Username);
                Console.WriteLine("Comments:");
                foreach (var items in item.Comments)
                {
                    
                    Console.WriteLine("- {0}", items);

                    
                }
                Console.WriteLine("Dates attended:");
                foreach (var dates in item.Dates.OrderBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Day))
                {
                    
                    Console.WriteLine("-- {0}", dates.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture));
                }

            }



        }
    }
    class Student
    {
        public string Username { get; set; }
        public List<DateTime> Dates { get; set; }
        public List<string> Comments { get; set; }
    }
}
