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
    /// Interaction logic for Factorial.xaml
    /// </summary>
    public partial class FactorialDeUnNumero : Window
    {
        public FactorialDeUnNumero()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, RoutedEventArgs e)
        {
            int numero, resultado;
            String res;
            numero = Convert.ToInt32(TextNumero.Text);
            resultado = Cap5.Factorial(numero);
            res = Convert.ToString(resultado);
            TextResultado.Text = res; 
            //MessageBox.Show("Factorial: "+resultado);
        }
    }
}
