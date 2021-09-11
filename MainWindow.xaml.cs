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

namespace asignacion2
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
        private void TablaMult(object sender, MouseButtonEventArgs e)
        {
            TablaMultp tabla = new TablaMultp();
            tabla.Owner = this;
            tabla.ShowDialog();
        }
        private void NumeroElevado(object sender, MouseButtonEventArgs e)
        {
            NumeroElevad NE = new NumeroElevad();
            NE.Owner = this;
            NE.ShowDialog();
        }

        private void PromedioEdades(object sender, MouseButtonEventArgs e)
        {
            PromedioEdad promedio = new PromedioEdad();
            promedio.Owner = this;
            promedio.ShowDialog();
        }

        private void llamarFactorial(object sender, MouseButtonEventArgs e)
        {
            FactorialDeUnNumero factorial = new FactorialDeUnNumero();
            factorial.Owner = this;
            factorial.ShowDialog();
        }
        private void Convert(object sender, MouseButtonEventArgs e)
        {
            ConvertirDeLetANumer convert = new ConvertirDeLetANumer();
            convert.Owner = this;
            convert.ShowDialog();
        }
    }
}
