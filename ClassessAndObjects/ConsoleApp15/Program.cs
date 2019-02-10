using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> Town1 = new List<Town>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                    break;
              
                
                string[] ReadInput = input.Split(' ').ToArray();
                bool itisatown = false;
                bool itisastudent = false;
                if (ReadInput.Contains("=>"))
                {
                    itisatown = true;
                }
                else
                {
                    itisastudent = true;
                }

                if (itisatown)
                {
                    ReadInput = input.Split(new char[] { '=', '>'}, StringSplitOptions.RemoveEmptyEntries);
                    Town town = new Town();
                    town.Name = ReadInput[0].TrimEnd().TrimStart();
                    string[] count = ReadInput[1].ToString().TrimEnd().TrimStart().Split(' ').ToArray();

                    town.SeatCount = Convert.ToInt32(count[0]);
                    Town1.Add(town);
                   
                }
                if (itisastudent)
                {
                   
                        string[] readintup = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                        string name = readintup[0];
                        string email = readintup[1];
                        string format = "d-MMM-yyyy";
                    string regdate = readintup[2].TrimStart().TrimEnd();
                        DateTime registrationdate = new DateTime();
                        registrationdate = DateTime.ParseExact(regdate, format, System.Globalization.CultureInfo.InvariantCulture);
                    Student student = new Student();
                    student.Name = name.TrimEnd().TrimStart();
                    student.Email = email.TrimStart().TrimEnd();
                    student.RegistrationDate = registrationdate;
                    Town1[Town1.Count() - 1].Student.Add(student);

                }



            }

            List<Group> Group = new List<Group>();

            foreach (var item in Town1.OrderBy(x => x.Name))
            {
                int numberofseats = item.SeatCount;
                int numberofgroups = 0;
                int counter = 0;
                int count = item.Student.Count();
                Group group = new Group();
                group.Town = item;
               
                    foreach (var items in item.Student.OrderBy(x => x.RegistrationDate).ThenBy(x => x.Name).ThenBy(x => x.Email))
                    {

                 
                    counter++;
                    count--;
                    if (counter <= numberofseats && count != 0)
                    {
                            group.Students.Add(items);
                        if (counter == numberofseats)
                        {
                            Group.Add(group);
                            group = new Group();
                            group.Town = item;
                            counter = 0;

                        }
                        

                     }
                   
               
                   
                    if (count == 0 && counter <= numberofseats )
                    {
                        group.Town = item;
                        counter = 0;
                        group.Students.Add(items);
                        Group.Add(group);

                     
                    }


                    }
           
            }

            Console.WriteLine("Created {0} groups in {1} towns:",Group.Count(),Town1.Count());
            foreach (var item in Group)
            {
                Console.Write("{0} => ", item.Town.Name);
                List<string> output = new List<string>();
                foreach (var items in item.Students)
                {
                   

                    output.Add(items.Email);
                    
                    
                }
                Console.WriteLine("{0}", String.Join(", ", output));
            }

        }

        class Student
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime RegistrationDate { get; set; }

            public Student()
            {
                this.RegistrationDate = new DateTime();

            }
        }

        class Town
        {
            public string Name { get; set; }
            public int SeatCount { get; set; }
            public List<Student> Student { get; set; }
            public Town()
            {
                this.Student = new List<Student>();

            }

        }

        class Group
        {
            public Town Town { get; set; }
            public List<Student> Students {get;set;}


            public Group()
            {
                this.Town = new Town();
                this.Students = new List<Student>();

            }




        }
    }
}
