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
using System.Windows.Shapes;

namespace asignacion2
{
    /// <summary>
    /// Interaction logic for NumeroElevad.xaml
    /// </summary>
    public partial class NumeroElevad : Window
    {
        public NumeroElevad()
        {
            InitializeComponent();
        }

        private void BtnElevarNumero(object sender, RoutedEventArgs e)
        {
            int numero, potencia;
            double resultado;
            String res;
            numero = Convert.ToInt32(TextNumero.Text);
            potencia = Convert.ToInt32(TextPotencia.Text);
            resultado = Cap4.numeroElevado(numero, potencia);
            res = Convert.ToString(resultado);
            TextResultado.Text = res;
        }
    }
}
