using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{   /* Create 4 members that Car, Truck, & SUV all have in common.
    * Example: All vehicles have a number of wheels... for now.. */
    public interface IVehicle
    {
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }
        public bool HasChangedGears { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool isChanged);

    }
}
