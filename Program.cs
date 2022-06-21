using System;

namespace Classes_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var PTCruiser = new Car();
                PTCruiser.Make = "Chrysler";
                PTCruiser.Model = "PT Cruiser";
                PTCruiser.Year = 2001;

            PTCruiser.CarShow(PTCruiser.Make, PTCruiser.Model, PTCruiser.Year);
        }
    }
}
