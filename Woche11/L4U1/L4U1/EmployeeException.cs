using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
  public class EmployeeException : ApplicationException
  {
    public EmployeeException() : base() { }
    public EmployeeException(string message) : base(message) { }
    public EmployeeException(string message, Exception innerException) : base(message, innerException) { }
  }
}