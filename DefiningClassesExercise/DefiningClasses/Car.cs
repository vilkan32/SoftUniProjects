using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Car
    {

        public string Model { get; set; }

        public double CarSpeed { get; set; }

        public Car(string model, double speed)
        {
            this.Model = model;
            this.CarSpeed = speed;
        }
              
        
    }
}
