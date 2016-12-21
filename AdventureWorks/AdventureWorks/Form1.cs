using System.Windows.Forms;

namespace AdventureWorks
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      DataAccess.Person person = new DataAccess.Person();

      var p = person.GetAllPersons();
    }
  }
}
