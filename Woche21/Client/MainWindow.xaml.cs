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
using System.Configuration;

namespace ZHAW.Philipp.Bachmann.L12
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
            this.txtServiceURL.Text = ConfigSettings.GetEndpointAddress();
            this.cboCalculate.SelectedIndex = 0;
        }

        private void txtServiceURL_TextChanged(object sender, TextChangedEventArgs e)
        {
            ConfigSettings.SaveEndpointAddress(this.txtServiceURL.Text);
        }

        private void btnDoIt_Click(object sender, RoutedEventArgs e)
        {
            string selectedOperation = this.cboCalculate.SelectionBoxItem.ToString();

            float parameter1 = 0;
            float.TryParse(this.txtParameter1.Text, out parameter1);

            float parameter2 = 0;
            float.TryParse(this.txtParameter2.Text, out parameter2);

            float returnvalue = 0;

            ServiceReferenceClient.CalculatorServiceClient client = new ServiceReferenceClient.CalculatorServiceClient();

            try
            {
                switch (selectedOperation)
                {
                    case "Addition":
                        returnvalue = client.Adding(new ServiceReferenceClient.CalculatorServiceParameter() { Parameter1 = parameter1, Parameter2 = parameter2 });
                        break;
                    case "Subtraction":
                        returnvalue = client.Subtraction(new ServiceReferenceClient.CalculatorServiceParameter() { Parameter1 = parameter1, Parameter2 = parameter2 });
                        break;
                    case "Multiplication":
                        returnvalue = client.Multiplication(new ServiceReferenceClient.CalculatorServiceParameter() { Parameter1 = parameter1, Parameter2 = parameter2 });
                        break;
                    case "Division":
                        returnvalue = client.Division(new ServiceReferenceClient.CalculatorServiceParameter() { Parameter1 = parameter1, Parameter2 = parameter2 });
                        break;
                }

                client.Close();
            }
            catch (Exception ex)
            {
                client.Abort();
                MessageBox.Show(string.Format("Something went wrong ! {0}", ex.Message), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            MessageBox.Show(string.Format("The Result is -> {0}", returnvalue), "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}