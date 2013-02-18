using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
  interface IEmployee
  {
    void DisplayStats();
    void GiveBonus(float amount);
    double GetBenefitCost();
  }
}