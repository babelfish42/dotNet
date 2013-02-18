using System;
using System.Collections.Generic;
using System.IO;
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

namespace L13U1
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private const string PATH = @"C:\L13U1.txt";

    public MainWindow()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Saves the text.
    /// </summary>
    private void SaveText()
    {
      try
      {
        // write it to the Filesystem
        FileInfo f = new FileInfo(PATH);
        using (BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
        {
          bw.Write(this.txtText.Text);
        }
        MessageBox.Show("Text successfully saved!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("Couldn't save the Text. Message {0}", ex.Message), "Information", MessageBoxButton.OK);
      }
    }

    /// <summary>
    /// Loads the text.
    /// </summary>
    private void LoadText()
    {
      try
      {
        // Load the Text
        FileInfo f = new FileInfo(PATH);
        using (BinaryReader br = new BinaryReader(f.OpenRead()))
        {
          this.txtText.Text = br.ReadString();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("Couldn't load the Text. Message {0}", ex.Message), "Information", MessageBoxButton.OK);
      }
    }

    private void btnSave_Click(object sender, RoutedEventArgs e)
    {
      SaveText();
    }

    private void btnLoad_Click(object sender, RoutedEventArgs e)
    {
      LoadText();
    }
  }
}
