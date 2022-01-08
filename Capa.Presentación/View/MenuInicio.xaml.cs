using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace Capa.Presentación.View
{
    /// <summary>
    /// Lógica de interacción para MenuInicio.xaml
    /// </summary>
    public partial class MenuInicio : System.Windows.Controls.UserControl
    {

        public Timer ti;

        public MenuInicio()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
        }

        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            TxtHora.Text = hoy.ToString("HH:MM:ss tt");
            TxtDiaNombre.Text = hoy.ToString("dddd");
            txtDia.Text = hoy.ToString("dd");
            TxtMes.Text = hoy.ToString("MMMM");
        }


        private void DataGrid_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void OnBtnMenuInventario(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
