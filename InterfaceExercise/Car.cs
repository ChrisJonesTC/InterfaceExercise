using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{/*Create 2 members that are specific to each class
 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. */
    public class Car : IVehicle , ICompany
    {
        
        public Car()
        {
        }

        public bool HasTrunk { get; set; } = true;
        public bool HasTurbo { get; set; } = true; 

        public double EngineSize { get; set; } = 4;
        public string Make { get; set; } = "Kia";
        public string Model { get; set; } = "Optima";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Movement that inspires";
        public bool HasChangedGears { get; set; }


        public void Drive()
        {
            Console.WriteLine($"Driving in my {GetType().Name}.");
        }
        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is in reverse.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is in park.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

    }
}
