using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L2U5_StringSolution
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = new int[1000];
      Random rnd = new Random();

      for (int indexnr = 0; indexnr < 1000; indexnr++)
      {
        int number = rnd.Next(1, 1000);
        numbers[indexnr] = number;
      }

      StringBuilder builder = new StringBuilder();

      for (int indexnr = 0; indexnr < 1000; indexnr++)
      {
        builder.Append(string.Format("{0}, ",numbers[indexnr]));
      }
      Console.WriteLine(builder.ToString());
      Console.ReadLine();
    }
  }
}
