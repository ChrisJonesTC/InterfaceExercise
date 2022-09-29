using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{/*Create 2 members that are specific to each class
 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. */
    public class Truck : IVehicle, ICompany
    {
        public Truck() 
        {
        }
        
        public bool HasBed { get; set; } = true;
        public bool HasHemi{ get; set; } = true;

        public double EngineSize { get; set; } = 8;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F150";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            if (HasHemi == true)
            {
                Console.WriteLine($"Hemi engine has started. {GetType().Name} is now driving.");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is in drive.");
            }
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
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
