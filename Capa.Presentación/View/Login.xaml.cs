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
using Capa.Entidad;
using Capa.Negocio;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace Capa.Presentación.View
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        //Cambiamos los nombres de nuestras clases a llamar
        LoginEntidades LEn = new LoginEntidades();
        LoginNegocio LNe = new LoginNegocio();

        public Timer ti;

        public Login()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;

        }

        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            txtReloj.Text = hoy.ToString("HH:MM:ss tt");
            txtHora.Text = hoy.ToString("dd");
            txtDia.Text = hoy.ToString("dddd");
            txtMesAño.Text = hoy.ToString("MMMM yyyy");
        }

        private void LLamarMenu()
        {
            MainWindow Menu = new MainWindow();
            Menu.Show();
        }


        private void OnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {


            DataTable dt = new DataTable();
            LEn.cUser = Usuario.Text;
            LEn.cPassword = Contraseña.Password;

            dt = LNe.LoginTableNegocio(LEn);

            if (dt.Rows.Count > 0)
            {
                LEn.cUser = dt.Rows[0][0].ToString();
                LEn.cPassword = dt.Rows[0][1].ToString();
                //System.Windows.MessageBox.Show("Bienvenido " + LEn.cUser);
                LLamarMenu();
                Close();
     
            }
            else
            {
                System.Windows.MessageBox.Show("Usuario o Contraseña Incorrecta");
            }

        }
    }
}
