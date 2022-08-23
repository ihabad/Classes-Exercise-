using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExercise1
{
    public class car

    {
        public car(string make, string model, int year)
    {
            Make = make;
            Model = model;
            Year = year;
    }
        public car()
        {

        }
     
        public string Make { get; set;}
        public string Model { get; set;}
        public int Year { get; set;}

    }

 }


