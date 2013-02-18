using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L9U2
{
  public class Logic
  {
    static SchoolEntities db = new SchoolEntities();

    /// <summary>
    /// Saves the person.
    /// </summary>
    /// <param name="person">The person.</param>
    public static void SavePerson(Person person)
    {
      db.Person.AddObject(person);
      db.SaveChanges();
    }

    /// <summary>
    /// Gets the persons.
    /// </summary>
    /// <returns></returns>
    public static List<Person> GetPersons()
    {
      return db.Person.ToList();
    }

    /// <summary>
    /// Gets the persons.
    /// </summary>
    /// <param name="FirstName">The first name.</param>
    /// <param name="Lastname">The lastname.</param>
    /// <returns></returns>
    public static List<Person> GetPersons(string FirstName, string Lastname)
    {
      if (string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(Lastname))
      {
        return GetPersons();
      }
      else
      {
        return db.Person.Where(p => p.FirstName == FirstName && p.LastName == Lastname).ToList();
      }
    }

  }
}