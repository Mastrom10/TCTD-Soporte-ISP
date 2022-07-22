using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using SERV;

namespace BLL
{
    public class ClienteBLL : GenericBLL<Cliente>
    {
        public ClienteBLL()
        {
            this.dal = new ClienteDAL();
            this.permiso = TipoPermiso.CRUDCliente;
        }

        public Cliente getByDNI(string dni)
        {
            return ((ClienteDAL)dal).GetByDni(dni);
        }

    }
}
