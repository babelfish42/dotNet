#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CarEvents
{
    public class Car
    {
        #region Basic Car state data / constructors
        // Internal state data.
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        public int slowSpeed { get; set; }

        // Is the car alive or dead?
        private bool carIsDead;

        public Car()
        {
            MaxSpeed = 100;
        }

        public Car(string name, int maxSp, int currSp, int slowSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
            slowSpeed = slowSp;
        }
        #endregion

        // This delegate works in conjunction with the
        // Car's events.
        public delegate void CarEngineHandler(object sender, CarEventArgs e);

        // This car can send these events.
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;
        public event CarEngineHandler SlowedDown;

        public void OnExploded(string message)
        {
          Exploded(this, new CarEventArgs(message));
        }

        public virtual void OnExploded(object sender, CarEventArgs message)
        {
          if (this.Exploded != null)
          {
            this.Exploded(sender, message);
          }
        }

        public void OnAboutToBlow(string message)
        {
          AboutToBlow(this, new CarEventArgs(message));
        }

        public virtual void OnAboutToBlow(object sender, CarEventArgs message)
        {
          if (this.AboutToBlow != null)
          {
            this.AboutToBlow(sender, message);
          }
        }

        public void OnSlowedDown(string message)
        {
          OnSlowedDown(this, new CarEventArgs(message));
        }

        public virtual void OnSlowedDown(object sender, CarEventArgs message)
        {
          if (this.SlowedDown != null)
          {
            this.SlowedDown(sender, message);
          }
        }

        public void Accelerate(int delta)
        {
            // If the car is dead, fire Exploded event.
            if (carIsDead)
            {
               OnExploded("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;

                // Almost dead?
                if (10 == MaxSpeed - CurrentSpeed
                  && AboutToBlow != null)
                {
                  OnAboutToBlow("Careful buddy!  Gonna blow!");
                }

                if (CurrentSpeed < slowSpeed)
                {
                  OnSlowedDown("Speed is slow");
                }

                // Still OK!
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
