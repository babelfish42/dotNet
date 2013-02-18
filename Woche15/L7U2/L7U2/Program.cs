using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Xml.Serialization;

namespace L7U2
{
  class Program
  {
    static void Main(string[] args)
    {
      Employee empl = new Employee("Müller", 28, 1, 10000, "ssn-0001");

      // Save it with a BinaryFormatter
      FileInfo f = new FileInfo(@"L7U2_EmployeeBin.txt");
      using (BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
      {
        bw.Write(empl.Age);
        bw.Write(empl.ID);
        bw.Write(empl.Name);
        bw.Write(empl.Pay);
        bw.Write(empl.SocialSecurityNumber);
      }

      // Save it with a SoapFormatter
      using (FileStream str = File.Create("L7U2_EmployeeSoap.txt"))
      {
        SoapFormatter sf = new SoapFormatter();
        sf.Serialize(str, empl);
      }

      // Save it with a XmlSerializer
      XmlSerializer SerializerObj = new XmlSerializer(typeof(Employee));

      TextWriter WriteFileStream = new StreamWriter(@"L7U2_EmployeeXml.txt");
      SerializerObj.Serialize(WriteFileStream, empl);

      WriteFileStream.Close();
    }
  }
}