using Semana03.ejercicio2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Semana03
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Datos cn = new Datos();
        public Window1()
        {
            InitializeComponent();
        }

        private void DgClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DgClientes_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Load(cn.ListaClientes());
            //DgClientes.ItemsSource = dt;
        }
    }
}
