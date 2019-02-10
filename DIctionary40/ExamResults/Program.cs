using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> AllOfTheResults = new List<Students>();
            Dictionary<string, int> Languages = new Dictionary<string, int>();
            while (true)
            {
                List<string> Input = Console.ReadLine().Split('-').ToList();
                if (Input[0] == "exam finished")
                {
                    break;
                }
                else if (Input.Count() == 2)
                {
                    for (int i = 0; i < AllOfTheResults.Count(); i++)
                    {
                        if (AllOfTheResults[i].Username == Input[0])
                        {
                            AllOfTheResults[i].Banned = true;
                        }
                    }
                }
                else if (Input.Count() == 3)
                {
                    Students local = new Students();
                    bool change = false;
                    for (int i = 0; i < AllOfTheResults.Count(); i++)
                    {
                        if (AllOfTheResults[i].Username == Input[0] && AllOfTheResults[i].Language == Input[1])
                        {
                            if (AllOfTheResults[i].Poins < int.Parse(Input[2]))
                            {
                                AllOfTheResults[i].Poins = int.Parse(Input[2]);
                            }
                               
                            change = true;
                        }
                    }
                    if (Languages.ContainsKey(Input[1]))
                    {
                        Languages[Input[1]] += 1;
                    }
                    else
                    {
                        Languages.Add(Input[1], 1);
                    }

                    if (change == false)
                    {
                        local.Banned = false;
                        local.Username = Input[0];
                        local.Language = Input[1];
                        local.Poins = int.Parse(Input[2]);
                        AllOfTheResults.Add(local);
                    }               
                }
               
            }
            Console.WriteLine("Results:");
            foreach (var item in AllOfTheResults.Where(x => x.Banned == false).OrderByDescending(x => x.Poins).ThenBy(x => x.Username))
            {
                Console.WriteLine($"{item.Username} | {item.Poins}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in Languages.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }
    }
    class Students
    {
        public string Username { get; set; }
        public string Language { get; set; }
        public int Poins { get; set; }
        public bool Banned { get; set; }
    }
}
