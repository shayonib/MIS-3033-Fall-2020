using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtFavColor.Text = string.Empty;
            txtName.Clear();
            btnClickMe.IsEnabled = false;
         
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked me!");
        }

        private void txtFavColor_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("You changed me.");

        }
    }
}
