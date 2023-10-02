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

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int NumeroAleatorio;
        public MainWindow()
        {
            InitializeComponent();
            Random r = new Random();
            NumeroAleatorio=r.Next(0, 101);
        }

        private void comprobar(object sender, RoutedEventArgs e)
        {

            if (int.Parse(intento.Text) == NumeroAleatorio)
            {
                mensaje.Text = "Has acertado";
            }
            else if (int.Parse(intento.Text) > NumeroAleatorio)
            {
                mensaje.Text = "te pasaste";
            }
            else
                mensaje.Text = "te quedaste corto";
        }

        private void reinicio(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            NumeroAleatorio = r.Next(0, 101);

            intento.Text = " ";
            mensaje.Text = " ";
        }
    }
}
