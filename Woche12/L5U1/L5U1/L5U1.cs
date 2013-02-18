using System;
using System.Collections.Generic;

namespace ZHAW.Philipp.Bachmann
{
  class L5U1
  {
    static void Main(string[] args)
    {
        List<string> list = new List<string>()
        {
          "Phil",
          "Marco",
          "Heini",
          "Peter",
          "Hans",
        };

        foreach(string item in list)
        {
          Console.WriteLine(item);
        }

        Console.ReadLine();
    }
  }
}
