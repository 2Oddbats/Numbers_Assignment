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

namespace Numbers_Assignment
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Declare Variables

            int myInteger = 0;

            double myDouble = 0.0;

            myInteger = Convert.ToInt32(textBoxFirstNum.Text);

            myDouble = Convert.ToDouble(textBoxSecondNumber.Text);

            string myLabel = "My Integer is: " + myInteger + "   My Double is: "
                + myDouble;

            label3.Content = myLabel;

        }
    }
}
