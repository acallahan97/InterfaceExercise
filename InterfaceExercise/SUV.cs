using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : ICompany, IVehicle
    {
        public int NumberOfPassengers { get; set; }
        public bool HasHeatedSeats { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }
        public bool HasWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public bool Drives { get; set; }
        public int NumberOfWheels { get; set; }
    }
}
