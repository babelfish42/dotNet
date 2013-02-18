using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson(string fullName, int age, int empID,
         float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empID, currPay, ssn, numbOfSales)
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
        }

        // No bonus for you! Error!
        //public override void GiveBonus(float amount)
        //{
        //    // Rats. Can't change this method any further.
        //}
    }


}
