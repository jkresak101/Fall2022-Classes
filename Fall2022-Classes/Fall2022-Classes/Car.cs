using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2022_Classes
{
    public class Car
    {
        //properties
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Speed { get; set; }
        public bool IsPaidFor { get; set; }
        
        //access ,pdifiers: public vs private vs interal
        //how we can access classes, properties, methods,etc, in our applications 

        //constructor
        public Car()
        {
            Make = "Lexus";
            Model = "RX 350";
            Color = "White";
            Year = 2018;
            Speed = 0;
            IsPaidFor = false;
        }

        public Car(string make, string model, string color, int year)
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
        }

        public Car(string make, string model, string color, int year, int speed, bool IsPaidFor)
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
        }

        //methods

    } 
}
