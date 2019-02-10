using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudentsLanguagePoints> AllOfTheStudents = new List<StudentsLanguagePoints>();
            Dictionary<string, int> LanguageNumberofSubmissions = new Dictionary<string, int>();
            int counter = 0;
            while (true)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();

                if (input[0] == "exam finished")
                {
                    break;
                }
                StudentsLanguagePoints studentsLanguagePoints = new StudentsLanguagePoints();

                if (input[1] == "banned")
                {

                    for (int i = 0; i < AllOfTheStudents.Count(); i++)
                    {
                        if (AllOfTheStudents[i].Name == input[0])
                        {
                            AllOfTheStudents[i].Banned = true;
                        }
                    }
                }
                else
                {
                    counter++;
                    if (counter == 1)
                    {
                        if (!LanguageNumberofSubmissions.ContainsKey(input[1]))
                        {
                            LanguageNumberofSubmissions.Add(input[1], 0);
                            LanguageNumberofSubmissions[input[1]] += 1;
                        }
                        else
                        {
                            LanguageNumberofSubmissions[input[1]] += 1;
                        }
                        studentsLanguagePoints.Name = input[0];

                        studentsLanguagePoints.Language = input[1];
                        studentsLanguagePoints.Points = Convert.ToInt32(input[2].ToString());

                    }
                    int counter1 = 0;
                    for (int i = 0; i < AllOfTheStudents.Count(); i++)
                    {
                        if (AllOfTheStudents[i].Name == input[0])
                        {
                            counter1++;
                            if (AllOfTheStudents[i].Points < Convert.ToInt32(input[2].ToString()))
                            {

                                AllOfTheStudents[i].Points = Convert.ToInt32(input[2].ToString());
                                AllOfTheStudents[i].Language = input[1];
                                if (!LanguageNumberofSubmissions.ContainsKey(input[1]))
                                {
                                    LanguageNumberofSubmissions.Add(input[1], 0);
                                    LanguageNumberofSubmissions[input[1]] += 1;
                                }
                                else
                                {
                                    LanguageNumberofSubmissions[input[1]] += 1;
                                }

                            }
                            else
                            {
                                if (!LanguageNumberofSubmissions.ContainsKey(input[1]))
                                {
                                    LanguageNumberofSubmissions.Add(input[1], 0);
                                    LanguageNumberofSubmissions[input[1]] += 1;
                                }
                                else
                                {
                                    LanguageNumberofSubmissions[input[1]] += 1;
                                }
                            }
                        }
                       
                    }

                    if (counter1 == 0 && counter != 1)
                    {

                        studentsLanguagePoints.Name = input[0];

                        studentsLanguagePoints.Language = input[1];
                        studentsLanguagePoints.Points = Convert.ToInt32(input[2].ToString());
                        if (!LanguageNumberofSubmissions.ContainsKey(input[1]))
                        {
                            LanguageNumberofSubmissions.Add(input[1], 0);
                            LanguageNumberofSubmissions[input[1]] += 1;
                        }
                        else
                        {
                            LanguageNumberofSubmissions[input[1]] += 1;
                        }
                    }
                    

                }

                if (studentsLanguagePoints.Name == null && studentsLanguagePoints.Language == null)
                {

                }
                else
                {
                    AllOfTheStudents.Add(studentsLanguagePoints);
                }

                
            }

            Console.WriteLine("Results:");
            foreach (var item in AllOfTheStudents.OrderByDescending(x => x.Points).ThenBy(y => y.Name).Where(z => z.Banned == false))
            {
                Console.WriteLine($"{item.Name} | {item.Points}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in LanguageNumberofSubmissions.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }

    class StudentsLanguagePoints
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public int Points { get; set; }
        public bool Banned { get; set; }
        public StudentsLanguagePoints()
        {
            Banned = false;
        }
    }
}
