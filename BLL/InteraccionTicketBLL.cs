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
    public  class InteraccionTicketBLL : GenericBLL<InteraccionTicket>
    {
        public InteraccionTicketBLL()
        {
            dal = new InteraccionTicketDAL();
            permiso = TipoPermiso.CRUDInteraccion;
        }

    }
}
