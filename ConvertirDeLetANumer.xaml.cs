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
    /// Interaction logic for ConvertirDeLetANumer.xaml
    /// </summary>
    public partial class ConvertirDeLetANumer : Window
    {
        public ConvertirDeLetANumer()
        {
            InitializeComponent();
        }

        private void BtnConverti(object sender, RoutedEventArgs e)
        {
            TextEscrito.Text = Cap5.Convertir(TextNumero.Text);
        }
    }
}
