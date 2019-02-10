using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        public string Name { get; set; }

        public string Birthday { get; set; }

        public List<Children> Childs { get; set; }

        public List<Parent> Parents { get; set; }

        public List<string> OrderOfInput { get; set; }

        public List<ParentChildren> ParentChildrenRelation { get; set; }

        public List<NameBirthday> NamesBirthdays { get; set; }

        public Person()
        {                       
            this.Parents = new List<Parent>();
            this.Childs = new List<Children>();
            this.ParentChildrenRelation = new List<ParentChildren>();
            this.OrderOfInput = new List<string>();
            this.NamesBirthdays = new List<NameBirthday>();
        }

    
        
        public void FillParentsAndChildren()
        {
            foreach (var item in ParentChildrenRelation)
            {
                // if he is a parent 
                if (item.ParentInformation == this.Name || item.ParentInformation == this.Birthday)
                {
                    if (!Childs.Contains(NamesBirthdays.Where(x => x.Name == item.ChildInformatio || x.Birthday == item.ChildInformatio).First()))
                    {
                        Childs.Add(NamesBirthdays.Where(x => x.Name == item.ChildInformatio || x.Birthday == item.ChildInformatio).First());
                    }
                }
                // if he is a child
                if (item.ChildInformatio == this.Name || item.ChildInformatio == this.Birthday)
                {
                    if (!Parents.Contains(NamesBirthdays.Where(x => x.Name == item.ParentInformation || x.Birthday == item.ParentInformation).First()))
                    {
                        Parents.Add(NamesBirthdays.Where(x => x.Name == item.ParentInformation || x.Birthday == item.ParentInformation).First());
                    }
                   
                }
               
            }
        }

        public void DisplayResult()
        {
            Console.WriteLine(this.Name + " " + this.Birthday);
            Console.WriteLine("Parents:");
         

            foreach (var item in this.Parents)
            {
                Console.WriteLine(item.Name + " " + item.Birthday);

            }

            Console.WriteLine("Children:");
          
            foreach (var item in Childs)
            {
                Console.WriteLine(item.Name + " " + item.Birthday);
            }
        }
    }
}
