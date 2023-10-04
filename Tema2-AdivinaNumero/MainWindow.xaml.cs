using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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
        private int numAleatorio;

        public MainWindow()
        {
            InitializeComponent();
            Random random = new Random();
            numAleatorio = random.Next(0, 101);

        }

        private void BotonComprobar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int numero = int.Parse(CasillaIntroduceNumero.Text);

                if (numero < numAleatorio)
                {
                    CasillaInforma.Text = "Te has quedado corto";
                    CasillaInforma.Foreground = Brushes.Red;
                }
                else if (numero > numAleatorio)
                {
                    CasillaInforma.Text = "Te has pasado";
                    CasillaInforma.Foreground = Brushes.Red;
                }
                else if (numero == numAleatorio)
                {
                    CasillaInforma.Text = "Lo has adivinado";
                    CasillaInforma.Foreground = Brushes.Green;
                    e.Handled = true;
                }
            }
            catch(Exception ex)
            {
                CasillaInforma.Text = "Escriba un número";
                CasillaInforma.Foreground = Brushes.Black;    
            }
            

        }

        private void BotonReiniciar_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            numAleatorio = random.Next(0, 101);
            CasillaIntroduceNumero.Text = "";
            CasillaInforma.Text = "";
        }
    }
}
