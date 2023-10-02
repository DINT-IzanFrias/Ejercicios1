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

namespace Tema2_Imagen
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 1;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.6;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.3;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Fill;
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Uniform;
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.UniformToFill;
        }

        private void RadioButton_Checked_6(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.None;
        }
    }
}
