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
            if (!Session.GetSession().TienePermiso(TipoPermiso.MostrarMensajeProtegido))
            { throw new Exception("No tiene permiso para realizar esta operacion" +
                "\nCodigo de Operacion: " + TipoPermiso.MostrarMensajeProtegido.ToString()); }
            
            
            
            return "Este mensaje está protegido";

        }
    }
}
