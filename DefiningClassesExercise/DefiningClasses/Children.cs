using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Children : Parent
    {
        
        public Children(string name,string birthday) : base(name,birthday)
        {
            
        }

        public Children(int index) : base(index)
        {
            
        }
    }
}
