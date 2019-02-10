using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
    {
        public static void Main(string[] args)
        {
            string mainPerson = Console.ReadLine();
            Person person = new Person();

            if (mainPerson.Split('/').Count() == 3)
            {
                person.Birthday = mainPerson;
            }
            else
            {
                person.Name = mainPerson;
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries).Select(x =>x.Trim()).ToArray();

                if (input[0] == "End")
                {
                    break;
                }

                if (input.Length == 2)
                {
                    person.OrderOfInput.AddRange(input);
                    person.ParentChildrenRelation.Add(new ParentChildren(input[0], input[1]));
                }
                else
                {
                    var info = input[0].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var name = info[0] + " " + info[1];
                    if (name == person.Name)
                    {
                        person.Birthday = info[2];
                        
                    }
                    if (info[2] == person.Birthday)
                    {
                        person.Name = name;
                    }
                    person.OrderOfInput.Add(name);
                    person.OrderOfInput.Add(info[2]);
                    person.NamesBirthdays.Add(new NameBirthday(name, info[2]));
                }

            }

            person.FillParentsAndChildren();

            person.DisplayResult();
        }
    }
}
