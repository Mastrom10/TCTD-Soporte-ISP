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
    public class ServicioBLL : GenericBLL<Servicio>
    {
        public ServicioBLL()
        {
            dal = new ServicioDAL();
            permiso = TipoPermiso.CRUDServicio;
        }

        public Servicio GetByCliente(Cliente cliente) {
            return ((ServicioDAL)dal).GetByCliente(cliente);
        }
    }
}
