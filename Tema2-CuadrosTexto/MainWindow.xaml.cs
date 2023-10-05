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

namespace Tema2_CuadrosTexto
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

        private void comprobar(object sender, ExecutedRoutedEventArgs e)
        {
            if(e.Key == Key.F1 && nombre.Text="")
            {
                nombre.Text = "nombre del ciente";
                apellido.Text = "apellido del cliente";
            }
            if(e.Key == Key.F1 && nombre.Text != "")
            {
                nombre.Text = "";
                apellido.Text = "";
            }

            if(e.Key==Key.F2)
            {
                long number1 = 0;
                bool canConvert = long.TryParse(edad.Text, out number1);
                if (canConvert == true)
                    edad.Text = "edad incorrecta";
                else
                {
                    edad.Text = "edad correcta";
                }
            }

        }
    }
}
