using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> Studenti = new List<Students>();
            while (true)
            {
                string[] student = Console.ReadLine().Split(' ').ToArray();
                if (student[0] == "end")
                {
                    break;
                }
                bool cango = true;
                for (int i = 0; i < Studenti.Count(); i++)
                {
                    if (Studenti[i].FirstName == student[0] && Studenti[i].LastName == student[1])
                    {
                        Studenti[i].Age = student[2];
                        Studenti[i].Town = student[3];
                        cango = false;
                    }
                }
                if (cango == true)
                {
                    Students local = new Students();
                    local.FirstName = student[0];
                    local.LastName = student[1];
                    local.Age = student[2];
                    local.Town = student[3];

                    Studenti.Add(local);
                }
                
            }
            string town = Console.ReadLine();

            foreach (var item in Studenti.Where(x => x.Town == town))
            {
                Console.WriteLine("{0} {1} is {2} years old.", item.FirstName, item.LastName, item.Age);
            }
        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Town { get; set; }
    }
}
