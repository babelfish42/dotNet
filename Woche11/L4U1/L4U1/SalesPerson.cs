using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    // Salespeople need to know their number of sales.
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }
      
        // As a general rule, all subclasses should explicitly call an appropriate
        // base class constructor.
        public SalesPerson(string fullName, int age, int empID,
          float currPay, string ssn, int numbOfSales)
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

            if (numbOfSales <= 0)
            {
              throw new EmployeeException("The numbOfSales is lower than 0");
            } 

            // This belongs with us!
            SalesNumber = numbOfSales;
        }

        // Add back the default ctor
        public SalesPerson() { }

        // A salesperson's bonus is influenced by the number of sales.
        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Sales: {0}", SalesNumber);
        }    
    }
}
