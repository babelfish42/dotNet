using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L2U4_ArraySolution
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

        // check number
        numbers[indexnr] = number;
      }
    }
  }
}
