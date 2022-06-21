using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_ex1
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void CarShow(string carMake, string carModel, int year)
        {
            Console.WriteLine($"The best car in the world is the {year} {carMake} {carModel}");
        }
    }
}
