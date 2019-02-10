using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> person;

        public List<Person> Person
        {
            get { return this.person; }
            set { this.person = value; }
        }
        public Family()
        {
            this.Person = new List<Person>();
        }
        public void AddMember(Person member)
        {
            this.Person.Add(member);
        }

       

       
    }
}
