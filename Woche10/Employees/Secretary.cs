using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
  class Secretary : Employee
  {
    public override void DisplayStats()
    {
      Console.WriteLine("Name: {0}", Name);
      Console.WriteLine("ID: {0}", ID);
      Console.WriteLine("Age: {0}", Age);
      Console.WriteLine("Pay: {0}", Pay);
      Console.WriteLine("SSN: {0}", SocialSecurityNumber);
      Console.WriteLine("LanguageKnowledge: {0}", LanguageKnowledge);
      Console.WriteLine("Education: {0}", Education);
    }

    public string LanguageKnowledge
    {
      get;
      set;
    }

    public string Education
    {
      get;
      set;
    }

    public double getFedTax(double salary)
    {
      double fedTax = (salary - 800) * .17;
      return fedTax;
    }

    public double getHealthFee(int rate, double salary)
    {
      double healthFee = (rate / 100) * salary;
      return healthFee;
    }
  }
}