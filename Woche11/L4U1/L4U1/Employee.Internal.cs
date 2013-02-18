﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    partial class Employee
    {
        #region Constructors
        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay, "") { }
        public Employee(string name, int age, int id, float pay, string ssn)
        {
          if (string.IsNullOrEmpty(name))
          {
            throw new EmployeeException("The Name is empty");
          }

          if (age <= 0)
          {
            throw new EmployeeException("The Age is invalid");
          }

          if (id <= 0)
          {
            throw new EmployeeException("The Id can't be lower than 0");
          }

          if (pay <= 0)
          {
            throw new EmployeeException("The Pay is invalid");
          }

          if (string.IsNullOrEmpty(ssn))
          {
            throw new EmployeeException("The ssn is empty");
          }

          // Better!  Use properties when setting class data.
          // This reduces the amount of duplicate error checks.
          Name = name;
          Age = age;
          ID = id;
          Pay = pay;
          SocialSecurityNumber = ssn;
        }
        static Employee()
        {
            companyName = "Intertech Training";
        }
        #endregion

        #region Properties
        public static string Company
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string Name
        {
            get { return empName; }
            set
            {
                // Here, value is really a string.
                if (value.Length > 15)
                    Console.WriteLine("Error!  Name must be less than 15 characters!");
                else
                    empName = value;
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
            set { empSSN = value; }
        }

        #endregion
    }
}