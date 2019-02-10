using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        // model, power, displacement and an efficiency
        private string model;

        private double power;

        private double displacement;

        private string efficiency;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public double Displacement
        {
            get { return this.displacement; }
            set { this.displacement = value; }
        }

        public string Efficiency
        {
            get { return this.efficiency; }
            set { this.efficiency = value; }
        }
        // displacements and efficiency are optional. 

        public Engine(string model, double power)
        {
            this.Model = model;
            this.Power = power;

            this.Efficiency = "n/a";
            this.Displacement = -1;
        }

        public Engine(string model, double power, double displacement) : this(model, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, double power, double displacement, string efficiency) : this(model, power, displacement)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, double power, string efficiency) : this(model, power)
        {
            this.Efficiency = efficiency;
        }

    }
}
