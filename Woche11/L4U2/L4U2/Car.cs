using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoProps
{
    class Car : IDisposable
    {
        // Automatic properties!
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        ~Car()
        {
          PetName = null;
          Speed = 0;
          Color = null;
        }

        public void Dispose()
        {
          PetName = null;
          Speed = 0;
          Color = null;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Car Name: {0}", PetName);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Color: {0}", Color);
        }
    }
}
