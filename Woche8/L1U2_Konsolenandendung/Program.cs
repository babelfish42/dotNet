using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L1_KW8
{
  class Program
  {
    /// <summary>
    /// Mains the specified args.
    /// </summary>
    /// <param name="args">The args.</param>
    public static void Main(string[] args)
    {
        Console.WriteLine("Benutzername eingeben:");
        string benutzername = Console.ReadLine();
        Console.WriteLine(string.Format("Hallo {0}", benutzername));
    }

  }
}
