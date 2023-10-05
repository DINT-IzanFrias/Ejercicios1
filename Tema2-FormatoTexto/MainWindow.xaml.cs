using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace Tema2_FormatoTexto
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            texto.FontWeight = FontWeights.Bold;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            texto.Foreground = Brushes.Red;
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            texto.FontStyle = FontStyles.Italic;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            texto.Foreground = Brushes.Green;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            texto.Foreground = Brushes.Blue;
        }
    }
}
