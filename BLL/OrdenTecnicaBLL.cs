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
    public class OrdenTecnicaBLL : GenericBLL<OrdenTecnica>
    {
        public OrdenTecnicaBLL() {
            dal = new OrdenTecnicaDAL();
            permiso = TipoPermiso.CRUDOrdenTecnica;
        }
    } 
}
