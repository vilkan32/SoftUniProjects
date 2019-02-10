﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Pokemon
    {
        // Pokemon have a name, an element and health

        private string name;

        private string type;

       

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

       
        public Pokemon(string name, string type)
        {
            this.Name = name;
            this.Type = type;
           
        }



    }
}