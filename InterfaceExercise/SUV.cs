using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{/*Create 2 members that are specific to each class
 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. */
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }

        public bool HasCargo { get; set; } = true;
        public bool HasFourWheelDrive { get; set; } = true;

        public double EngineSize { get; set; } = 6;
        public string Make { get; set; } = "Cadillac";
        public string Model { get; set; } = "Escalade";
        public int SeatCount { get; set; } = 6;
        public string CompanyName { get; set; } = "Cadillac";
        public string Motto { get; set; } = "Standard of the World";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward.");
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
