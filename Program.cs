using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace ClassesExercise1

{
   
    internal class Program 

    {
        public static string Make { get; set; }
        public static string Model { get; set; }
        public static int Year { get; set; }


        static void Main(string[] arg)
        {
         
            car myCar = new car();

            myCar.Make = "BMW";
            myCar.Model = "i8";
            myCar.Year = 2019;


         

            var audi = new car();
            {
                audi.Make = "audi";
                audi.Model = "R8";
                audi.Year = 2022;
            }

            var Honda = new car("Honda", "CV", 2018);

            var carlist = new List<car>() { myCar, audi, Honda };



            foreach (var item in carlist)
            {


                Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year}");
                Console.WriteLine($"{audi.Make} {audi.Model} {audi.Year}");


            }
        }
    }
}


