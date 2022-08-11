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
    public class TicketBLL: GenericBLL<Ticket>
    {
        InteraccionTicketBLL interaccionBLL;

        public TicketBLL() {
            dal = new TicketDAL();
            interaccionBLL = new InteraccionTicketBLL();
            permiso = TipoPermiso.CRUDTicket;
        }

        public override void Create(Ticket ticket)
        {
           

            if (ticket.cliente == null || ticket.cliente.Id == 0)
                throw new Exception("El cliente no puede ser nulo");

            ticket.estado = EstadoTicket.Abierto;
            ticket.fechaCreacion = DateTime.Now;
            ticket.fechaUltimaModificacion = DateTime.Now;
            ticket.empleado = Session.GetSession().usuario.empleado;
            //int IDTicket = ((TicketDAL)dal).CreateWithID(ticket);
            base.Create(ticket);

            ticket.interacciones = new List<InteraccionTicket>();
                InteraccionTicket interaccion = new InteraccionTicket();
                interaccion.idTicket = ticket.Id;
                interaccion.fecha = DateTime.Now;
                interaccion.empleado = Session.GetSession().usuario.empleado;
                interaccion.observacion = "Se ha creado el ticket";
                interaccion.accion = "Creacion de ticket";
            ticket.interacciones.Add(interaccion);
            interaccionBLL.Create(interaccion);



        }


        public List<Ticket> GetTicketsByCliente(Cliente cliente)
        {
            TipoPermiso permisoEspecifico = TipoPermiso.CRUDTicket;
            if (!Session.GetSession().TienePermiso(permisoEspecifico)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());

            return ((TicketDAL)dal).GetByCliente(cliente);
        }
    }
}
