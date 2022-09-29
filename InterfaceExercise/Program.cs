using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var truck = new Truck();
            var suv = new SUV();
            var vehicles = new List<IVehicle>() { car, truck, suv};

            var companyInfo = new List<ICompany>() { car, truck, suv };
            
            
            
            foreach (var vehicle in vehicles)
            {
               
                
                Console.WriteLine($"Make: {vehicle.Make} Model: {vehicle.Model} Engine size: {vehicle.EngineSize} SeatCount: {vehicle.SeatCount}");
                Console.WriteLine();
                
                
                vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();
            }
            
        }
    }
}
