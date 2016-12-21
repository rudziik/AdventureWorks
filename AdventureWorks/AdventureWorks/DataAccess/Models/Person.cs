using System;

namespace AdventureWorks.DataAccess.Models
{
  public class Person
  {
    public Guid BusinessEntityID { get; set; }

    public string PersonType { get; set; }

    public bool NameStyle { get; set; }

    public string Title { get; set; }

    public string FirstName { get; set; }

    public char MiddleName { get; set; }

    public string LastName { get; set; }

    public string Suffix { get; set; }

    public int EmailPromotion { get; set; }

    public string AdditionalContactInfo { get; set; }

    public string Demographics { get; set; }    
  }
}
