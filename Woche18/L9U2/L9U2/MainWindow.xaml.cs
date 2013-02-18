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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace L9U2
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      this.DataContext = Logic.GetPersons();
    }

    private void btnAdd_Click(object sender, RoutedEventArgs e)
    {
      Detail detail = new Detail();
      detail.ShowDialog();

      if (detail.isSaved)
      {
        this.DataContext = Logic.GetPersons();
      }
    }

    private void btnSearch_Click(object sender, RoutedEventArgs e)
    {
      this.DataContext = Logic.GetPersons(this.txtFirstName.Text, this.txtLastName.Text);
    }
  }
}
