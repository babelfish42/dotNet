using System;

namespace Employees
{
  /// <summary>
  /// ITSpecialist
  /// </summary>
  class ITSpecialist : Employee
  {
    public override void DisplayStats()
    {
      Console.WriteLine("Name: {0}", Name);
      Console.WriteLine("ID: {0}", ID);
      Console.WriteLine("Age: {0}", Age);
      Console.WriteLine("Pay: {0}", Pay);
      Console.WriteLine("SSN: {0}", SocialSecurityNumber);
      Console.WriteLine("SpecialistKnowledge: {0}", SpecialistKnowledge);
      Console.WriteLine("Education: {0}", Education);
    }

    public string SpecialistKnowledge
    {
      get; set;
    }

    public string Education
    {
      get; set;
    }

    public double getFedTax(double salary)
    {
      double fedTax = (salary - 800) * .17;
      return fedTax;
    }

    public double getSsTax(int rate, double salary)
    {
      double ssTax = salary * (rate / 100);
      return ssTax;
    }
  }
}