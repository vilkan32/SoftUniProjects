using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class ParentChildren
    {
        public string ParentInformation { get; set; }

        public string ChildInformatio { get; set; }

        public ParentChildren(string parentInformation, string childInformation)
        {
            this.ParentInformation = parentInformation;
            this.ChildInformatio = childInformation;
        }
    }
}
