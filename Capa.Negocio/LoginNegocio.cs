using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Datos;
using Capa.Entidad;

namespace Capa.Negocio
{
    public class LoginNegocio
    {
        LoginDatos obje = new LoginDatos();
        public DataTable LoginTableNegocio(LoginEntidades obj)
        {
            return obje.LoginTableDatos(obj);
        }
    }
}
