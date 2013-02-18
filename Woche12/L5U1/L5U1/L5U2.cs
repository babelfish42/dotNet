using System;
using System.Collections.Generic;

namespace ZHAW.Philipp.Bachmann
{
  public class Person : IComparer<Person>
  {
    public string Name { get; set; }
    public int Age { get; set; }

    public int Compare(Person x, Person y)
    {
      return x.Name.CompareTo(y.Name);
    }
  }

  class L5U2
  {
    static void Main(string[] args)
    {     
      List<Person> people = new List<Person>()
      {
        new Person() {Age = 16, Name = "Phil"},
        new Person() {Age = 18, Name = "Marco"},
        new Person() {Age = 19, Name = "Heini"},
        new Person() {Age = 22, Name = "Peter"},
        new Person() {Age = 25, Name = "Hans"}
      };

      people.Sort((o1, o2) => o1.Name.CompareTo(o2.Name));

      foreach (var person in people)
      {
        Console.WriteLine(string.Format("Name -> {0}", person.Name));
      }

      Console.ReadLine();
    }
  }
}