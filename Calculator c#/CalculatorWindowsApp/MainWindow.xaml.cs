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

namespace CalculatorWindowsApp
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
        double number1, number2;
        
        private void NumberParse()
        {
            double.TryParse(TBnumber1.Text, out number1);
            double.TryParse(TBnumber2.Text, out number2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NumberParse();
            result.Content = (number1 + number2).ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            NumberParse();
            result.Content = (number1 - number2).ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            NumberParse();
            result.Content = (number1 * number2).ToString();
        }

        private void TBnumber2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            NumberParse();
            result.Content = (number1 / number2).ToString();
        }
    }
}
