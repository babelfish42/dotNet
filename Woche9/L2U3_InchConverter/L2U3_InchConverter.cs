using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L2U3_InchConverter
{
  public class Program
  {
    static void Main(string[] args)
    {

    }
  }

  public class L2U3_InchConverter
  {
    private static readonly double CONVERTVALUE = 2.54;

    /// <summary>
    /// Converts the CM to INCH.
    /// </summary>
    /// <param name="cm">The cm.</param>
    /// <returns></returns>
    public static double ConvertCMtoINCH(double cm)
    {
      return (cm/CONVERTVALUE);
    }

    /// <summary>
    /// Converts the INCH to CM.
    /// </summary>
    /// <param name="inch">The inch.</param>
    /// <returns></returns>
    public static double ConvertINCHtoCM(double inch)
    {
      return (inch*CONVERTVALUE);
    }
  }
}
