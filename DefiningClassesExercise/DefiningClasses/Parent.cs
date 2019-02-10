using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class Parent
    {
        public string Name { get; set; }

        public string Birthday { get; set; }

        public int Index { get; set; }
        public Parent(string name, string birthday) 
        {
            this.Name = name;
            this.Birthday = birthday;
        }
        public Parent(int index)
        {
            this.Index = index;
        }

    }
}
