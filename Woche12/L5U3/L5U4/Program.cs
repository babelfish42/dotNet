using System;
using System.IO;
using System.Linq;

namespace L5U4
{
  class Program
  {
    static void Main(string[] args)
    {
      var selectedFiles1 = from FileInfo f in new DirectoryInfo(@"c:\temp\temp1").GetFiles("*.*", SearchOption.AllDirectories)
                          where f.Name.StartsWith("A")
                          select new { Name = f.FullName, LastAccessTime = f.LastAccessTime, CreationTime = f.CreationTime, Length = f.Length };

      var selectedFiles2 = from FileInfo f in new DirectoryInfo(@"c:\temp\temp2").GetFiles("*.*", SearchOption.AllDirectories)
                           where f.Name.StartsWith("B")
                           select new { Name = f.FullName, LastAccessTime = f.LastAccessTime, CreationTime = f.CreationTime, Length = f.Length };

      var allfiles = selectedFiles1.Union(selectedFiles2).OrderBy(f => f.LastAccessTime);

      foreach (var info in allfiles)
      {
        Console.WriteLine(string.Format("Fullname = {0}", info.Name));
      }

      Console.ReadLine();
    }
  }
}