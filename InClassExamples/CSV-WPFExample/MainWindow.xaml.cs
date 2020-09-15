using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSV_WPFExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, RoutedEventArgs e)
        {
            filePath = txtFilePath.Text;

            if(File.Exists(filePath)== true)
            {
                btnProcessFile.IsEnabled = true;
                btnValidate.IsEnabled = false;
                txtFilePath.IsEnabled = false;
                
            }
            else
            {
                MessageBox.Show("Invalid file path. Please try again", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtFilePath.Clear();
                txtFilePath.Focus();
            }
        }

        private void btnProcessFile_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = File.ReadAllLines(filePath);
            double sum = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                var pieces = line.Split(',');
                double price;

                if (Double.TryParse(pieces[2], out price)== true)
                {
                    sum += Convert.ToDouble(pieces[2]);
                }
                else
                {

                    MessageBox.Show($"Sorry, there was an invalid Price on line {i+1}");
                }
              
                lstFile.Items.Add(pieces[1]);

            }
            MessageBox.Show($"The sum of all the product prices is {sum.ToString("C2")}.");
            // foreach (var line in lines)
            // {
            //     lstFile.Items.Add(line);
            // }

        }
    }
}
