using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoProps
{
    class Garage
    {
        // The hidden backing field is set to zero!
        public int NumberOfCars { get; set; }

        // The hidden backing field is set to null!
        public Car MyAuto { get; set; }

        ~Garage()
        {
          MyAuto = null;
          NumberOfCars = 0;
        }

        public void Dispose()
        {
          MyAuto = null;
          NumberOfCars = 0;
        }

        // Must use constructors to override default 
        // values assigned to hidden backing fields.
        public Garage()
        {
            MyAuto = new Car();
            NumberOfCars = 1;
        }

        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }

}
