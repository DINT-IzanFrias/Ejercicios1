using System.Windows;
using System.Windows.Controls;

namespace Tema2_CalculadoraBasica
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
            resultado.Text = "";
            numero1.Text = "";
            numero2.Text = "";
            signo.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (signo.Text == "+")
            {
                int suma = int.Parse(numero1.Text) + int.Parse(numero2.Text);

                resultado.Text = suma.ToString();
            }
            if (signo.Text == "-")
            {
                int suma = int.Parse(numero1.Text) - int.Parse(numero2.Text);

                resultado.Text = suma.ToString();
            }
            if (signo.Text == "*")
            {
                int suma = int.Parse(numero1.Text) * int.Parse(numero2.Text);

                resultado.Text = suma.ToString();
            }
            if (signo.Text == "/")
            {
                int suma = int.Parse(numero1.Text) / int.Parse(numero2.Text);

                resultado.Text = suma.ToString();
            }
            else
            {
                resultado.Text = "no es un signo valido";
            }
        }
    }
}
