using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Capa.Entidad;

namespace Capa.Datos
{
    public class LoginDatos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable LoginTableDatos(Capa.Entidad.LoginEntidades obj)
        {
            SqlCommand cmd = new SqlCommand("InicioSesionUsuario_sp", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cUser", obj.cUser);
            cmd.Parameters.AddWithValue("@cPassword", obj.cPassword);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable DatosTabla = new DataTable();
            da.Fill(DatosTabla);
            return DatosTabla;
        }


    }
}
