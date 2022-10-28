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
    public class InteraccionTicketBLL : GenericBLL<InteraccionTicket>
    {
        public InteraccionTicketBLL()
        {
            dal = new InteraccionTicketDAL();
            permiso = TipoPermiso.CRUDInteraccion;
        }
         
        public List<InteraccionTicket> GetAllByTicket(Ticket ticket)
        {
            if (!Session.GetSession().TienePermiso(this.permiso))
            {
                logger.Log("No tiene permiso para realizar esta accion", LogLevel.Warning, "Permiso Faltante: " + this.permiso.ToString(), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + this.permiso.ToString());
            }

            // logger.Log("Se obtuvieron los dispositivos del servicio " + servicio.Id, Level.Debug, SERV.Serializacion.LogSerializer.Serialize(dispositivos), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
            logger.Log("Se obtuvieron las interacciones del ticket " + ticket.Id, LogLevel.Debug, null,  this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
            return ((InteraccionTicketDAL)dal).GetAllByTicketID(ticket.Id);
        }

    }
}
