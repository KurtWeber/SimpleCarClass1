using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Car
    {
        // Fields
        private string make;
        private string model;
        private int year;
        private string color;

        // Properties for each variable
        public string Make
        {
            get { return this.make; }
            set { make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { model = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { year = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { color = value; }
        }

        // Constructor
        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        // Method
        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
            {
                carValue = 10000;
            }
            else
            {
                carValue = 2000;
            }
            return carValue;
        }
    }
}
