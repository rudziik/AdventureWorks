using System.Data;
using System.Data.SqlClient;

namespace AdventureWorks.DataAccess
{
  public class Person
  {
    private readonly SqlConnection ConnectionString = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString);

    public DataSet GetAllPersons()
    {
      SqlDataAdapter daPerson = new SqlDataAdapter();
      DataSet dsPerson = new DataSet();
      DataTable dtPerson = new DataTable();

      daPerson.SelectCommand = new SqlCommand("SELECT * FROM Person.Person", ConnectionString);
      daPerson.Fill(dsPerson, "Person");
      dtPerson = dsPerson.Tables["Person"];

      return dsPerson;
    }
  }
}
