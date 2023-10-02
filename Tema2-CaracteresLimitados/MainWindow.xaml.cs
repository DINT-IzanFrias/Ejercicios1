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

namespace Tema2_CaracteresLimitados
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtInput.TextChanged += TxtInput_TextChanged;
            UpdateCharacterCount();
        }

      private void TxtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Actualizar el contador cuando cambie el texto
            UpdateCharacterCount();
        }

        private void UpdateCharacterCount()
        {
            int remainingCharacters = 140 - txtInput.Text.Length;
            txtCharacterCount.Text = $"Caracteres restantes: {remainingCharacters}";
        }
    }
}
