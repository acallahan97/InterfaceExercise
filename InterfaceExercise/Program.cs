using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car car1 = new Car();
            car1.CompanyName = "Honda";
            car1.Drives = true;
            car1.EngineSound = "Vroom Vroom";
            car1.HasWheels = true;
            car1.Logo = "Power of Dreams";
            car1.NumberOfDoors = 4;
            car1.NumberOfPassengers = 5;
            car1.NumberOfWheels = 4;

            Console.WriteLine($"Company Name: {car1.CompanyName}" +
                $"Runs and drives: {car1.Drives}" +
                $"Engine Sound: {car1.EngineSound}" +
                $"Has Wheels: {car1.HasWheels}" +
                $"Logo: {car1.Logo}" +
                $"Number of doors: {car1.NumberOfDoors}" +
                $"Number of passengers: {car1.NumberOfPassengers}" +
                $"Number of wheels: {car1.NumberOfWheels}");
            Console.WriteLine();

            Truck truck1 = new Truck();
            truck1.CompanyName = "Ford";
            truck1.Drives = false;
            truck1.Has4WheelDrive = true;
            truck1.HasWheels = true;
            truck1.Logo = "Built Ford Tough";
            truck1.NumberOfDoors = 4;
            truck1.NumberOfPassengers = 5;
            truck1.NumberOfWheels = 4;

            Console.WriteLine($"Company Name: {truck1.CompanyName}" +
                $"Runs and drives: {truck1.Drives}" +
                $"Has 4 Wheel Drive: {truck1.Has4WheelDrive}" +
                $"Has Wheels: {truck1.HasWheels}" +
                $"Logo: {truck1.Logo}" +
                $"Number of doors: {truck1.NumberOfDoors}" +
                $"Number of passengers: {truck1.NumberOfPassengers}" +
                $"Number of wheels: {truck1.NumberOfWheels}");
            Console.WriteLine();

            SUV suv1 = new SUV();
            suv1.CompanyName = "Cadillac";
            suv1.Drives = true;
            suv1.HasHeatedSeats = true;
            suv1.HasWheels = true;
            suv1.Logo = "The Standard of the World Award";
            suv1.NumberOfWheels = 4;
            suv1.NumberOfDoors = 4;
            suv1.NumberOfPassengers = 7;

            Console.WriteLine($"Company Name: {suv1.CompanyName}" + 
                $"Runs and drives: {suv1.Drives}" +
                $"Has Heated Seats: {suv1.HasHeatedSeats}" +
                $"Has Wheels: {suv1.HasWheels}" +
                $"Logo: {suv1.Logo}" +
                $"Number of doors: {suv1.NumberOfDoors}" +
                $"Number of passengers: {suv1.NumberOfPassengers}" +
                $"Number of wheels: {suv1.NumberOfWheels}");
            Console.WriteLine();




        }
    }
}
