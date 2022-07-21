using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERV;
using BE;

namespace BLL
{
    public class TestBLL
    {

        public string MostrarMensajeProtegido()
        {
            TipoPermiso permisoEspecifico = TipoPermiso.MostrarMensajeProtegido;
            if (!Session.GetSession().TienePermiso(permisoEspecifico)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());
            
            
            
            return "Este mensaje está protegido";

        }
    }
}
