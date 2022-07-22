using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using SERV;
using DAL;

namespace BLL
{
    public class DireccionBLL : GenericBLL<Direccion>
    {
        public DireccionBLL()
        {
            dal = new DireccionDAL();
            permiso = TipoPermiso.CRUDDireccion;
        }

        public Direccion getByCliente(Cliente cliente) {
            return ((DireccionDAL)dal).GetByCliente(cliente);
        }

        
    }
}
