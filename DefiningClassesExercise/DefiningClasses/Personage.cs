using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Personage
    {

        public string Name { get; set; }

        public Company Company { get; set; }

        public Car Car { get; set; }

        public List<Pokemon> Pokemon { get; set; }

        public List<Parent> Parents { get; set; }

        public List<Children> Children { get; set; }

        public Personage(string name)
        {
            this.Name = name;

            this.Pokemon = new List<Pokemon>();

            this.Parents = new List<Parent>();

            this.Children = new List<Children>();
        }

        public Personage(Company company)
        {
            this.Company = company;     
        }

        public Personage(Car car)
        {
            this.Car = car;
        }

        public Personage(Pokemon pokemon)
        {
            this.Pokemon.Add(pokemon);
        }

        public Personage(Parent parents)
        {
            this.Parents.Add(parents);
        }

        public Personage(Children children)
        {
            this.Children.Add(children);
        }

    }
}
