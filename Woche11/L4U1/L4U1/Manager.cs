using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    // Managers need to know their number of stock options.
    class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager(string fullName, int age, int empID,
          float currPay, string ssn, int numbOfOpts)
            : base(fullName, age, empID, currPay, ssn)
        {

            if (string.IsNullOrEmpty(fullName))
            {
              throw new EmployeeException("The fullName is empty");
            }

            if (age <= 0)
            {
              throw new EmployeeException("The Age is invalid");
            }

            if (empID <= 0)
            {
              throw new EmployeeException("The empID can't be lower than 0");
            }

            if (currPay <= 0)
            {
              throw new EmployeeException("The currPay is invalid");
            }

            if (string.IsNullOrEmpty(ssn))
            {
              throw new EmployeeException("The ssn is empty");
            }

            if (numbOfOpts <= 0)
            {
              throw new EmployeeException("The numbOfOpts is lower than 0");
            }

            // This field is defined by the Manager class.
            StockOptions = numbOfOpts;
        }
        // Add back the default ctor
        public Manager() {}

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOptions);
        }
    }
}
