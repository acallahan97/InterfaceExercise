using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public bool HasWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public bool Drives { get; set; }
        public int NumberOfWheels { get; set; }
    }
}
