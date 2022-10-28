using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class NodoRedBLL : GenericBLL<NodoRed>
    {
        public NodoRedBLL(){
            dal = new NodoRedDAL();
            permiso = TipoPermiso.CRUDNodoRed;
        } 
    }
}
