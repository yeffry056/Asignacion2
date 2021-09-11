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
    /// Interaction logic for TablaMultp.xaml
    /// </summary>
    public partial class TablaMultp : Window
    {
        public TablaMultp()
        {
            InitializeComponent();
        }

        private void BtnTabla(object sender, RoutedEventArgs e)
        {
            if (TextResultado.Text != null)
                TextResultado.Text = null;
            int[] arreglo = new int[10];
            int numero = Convert.ToInt32(TextRes.Text);
            arreglo = Cap4.Tabla(numero);
            for(int i = 1; i < 11; i++)
                TextResultado.Text += (numero+" X "+i+" = "+arreglo[i-1]+"\n");
        }
    }
}
