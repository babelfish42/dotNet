using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace L9U2
{
  /// <summary>
  /// Interaction logic for Detail.xaml
  /// </summary>
  public partial class Detail : Window
  {
    public bool isSaved = false;

    public Detail()
    {
      InitializeComponent();
    }

    private void btnAdd_Click(object sender, RoutedEventArgs e)
    {
      if (this.txtFirstName.Text.Length == 0 || this.txtLastname.Text.Length == 0)
      {
        MessageBox.Show("Please fill in all required fields", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        return;
      }

      Person newperson = new Person()
        {
          LastName = this.txtLastname.Text,
          FirstName = this.txtFirstName.Text,
          EnrollmentDate = this.datEnrollement.SelectedDate,
          HireDate = this.datHiredate.SelectedDate
        };

      Logic.SavePerson(newperson);
      isSaved = true;
      this.Close();
    }

    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}
