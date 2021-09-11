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
    /// Interaction logic for PromedioEdad.xaml
    /// </summary>
    public partial class PromedioEdad : Window
    {
        private int cantidad = 0;
        private int[] Edad = new int[50];
        public PromedioEdad()
        {
            InitializeComponent();
            
        }

        private void BtnAgregar(object sender, RoutedEventArgs e)
        {
           
            if(cantidad < 10)
                cantidad++;
            Edad[cantidad] = Convert.ToInt32(TextEdad.Text);
            TextEdad.Text = null;
           

        }

        private void BtnCalcular(object sender, RoutedEventArgs e)
        {
            int[] resultado = new int[4];
            resultado = Cap4.Edades(Edad, cantidad);
            TextPromedio.Text = Convert.ToString(resultado[0]);
            TextMayor.Text = Convert.ToString(resultado[1]);
            TextMenor.Text = Convert.ToString(resultado[2]);
        }
    }
}
