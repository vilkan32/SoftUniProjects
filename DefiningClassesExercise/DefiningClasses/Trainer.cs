using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;

        private int numberOfBadges;

        private List<Pokemon> pokemon = new List<Pokemon>();
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int NumberOfBadges
        {
            get { return this.numberOfBadges; }
            set { this.numberOfBadges = value; }
        }
        public List<Pokemon> Pokemon
        {
            get { return this.pokemon; }
            set { this.pokemon = value; }
        }

        public Trainer(string name, Pokemon pokemon)
        {
            this.Name = name;
            this.Pokemon.Add(pokemon);
            this.NumberOfBadges = 0;
            
        }



    }
}
