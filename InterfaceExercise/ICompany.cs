using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{ /*Create 2 members that are specific to each every company
  * regardless of vehicle type.
  * Example: public string Logo { get; set; }  */
    public interface ICompany
    {
        public string CompanyName { get; set; }
        public string Motto { get; set; }

    }
}
