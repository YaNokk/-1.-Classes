using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            canva.Children.Clear();
            Elipse elipse = new Elipse(int.Parse(X1.Text), int.Parse(Y1.Text), int.Parse(X2.Text), int.Parse(Y2.Text));
            elipse.Draw(canva);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Elipse elipse = new Elipse(int.Parse(X1.Text), int.Parse(Y1.Text), int.Parse(X2.Text), int.Parse(Y2.Text));
            MessageBox.Show(elipse.isCirle() ? "Да" : "Нет");
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Elipse elipse = new Elipse(int.Parse(X1.Text), int.Parse(Y1.Text), int.Parse(X2.Text), int.Parse(Y2.Text));
            MessageBox.Show(elipse.Info());
        }
    }
}
