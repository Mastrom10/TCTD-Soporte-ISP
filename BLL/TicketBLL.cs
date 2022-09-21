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

        //getTicketsByEstado
        public List<Ticket> GetTicketsByEstado(EstadoTicket estado)
        {
            TipoPermiso permisoEspecifico = TipoPermiso.CRUDTicket;
            if (!Session.GetSession().TienePermiso(permisoEspecifico)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());
           
            return ((TicketDAL)dal).GetByEstado(estado);
        }

        public void Update(Ticket ticketActual, Ticket ticketActualizado)
        {
            


            if (ticketActual.titulo != ticketActualizado.titulo) {
                InteraccionTicket interaccion = new InteraccionTicket();
                interaccion.idTicket = ticketActual.Id;
                interaccion.fecha = DateTime.Now;
                interaccion.empleado = Session.GetSession().usuario.empleado;
                interaccion.motivo = "Actualizacion Datos";
                interaccion.observacion = "Anterior: " + ticketActual.titulo + "\n Actual: " + ticketActualizado.titulo;
                interaccion.accion = "Cambio de titulo";
                ticketActual.interacciones.Add(interaccion);
                interaccionBLL.Create(interaccion);
                ticketActual.titulo = ticketActualizado.titulo;
                ticketActual.fechaUltimaModificacion = DateTime.Now;
            }
            if (ticketActual.prioridad != ticketActualizado.prioridad)
            {
                InteraccionTicket interaccion = new InteraccionTicket();
                interaccion.idTicket = ticketActual.Id;
                interaccion.fecha = DateTime.Now;
                interaccion.empleado = Session.GetSession().usuario.empleado;
                interaccion.motivo = "Actualizacion Datos";
                interaccion.observacion = "Anterior: " + ticketActual.prioridad + "\n Actual: " + ticketActualizado.prioridad;
                interaccion.accion = "Cambio de prioridad";
                ticketActual.interacciones.Add(interaccion);
                interaccionBLL.Create(interaccion);
                ticketActual.prioridad = ticketActualizado.prioridad;
                ticketActual.fechaUltimaModificacion = DateTime.Now;
            }
            if (ticketActual.descripcion != ticketActualizado.descripcion)
            {
                InteraccionTicket interaccion = new InteraccionTicket();
                interaccion.idTicket = ticketActual.Id;
                interaccion.fecha = DateTime.Now;
                interaccion.empleado = Session.GetSession().usuario.empleado;
                interaccion.motivo = "Actualizacion Datos";
                interaccion.observacion = "Anterior: " + ticketActual.descripcion + "\n Actual: " + ticketActualizado.descripcion;
                interaccion.accion = "Cambio de descripcion";
                ticketActual.interacciones.Add(interaccion);
                interaccionBLL.Create(interaccion);
                ticketActual.descripcion = ticketActualizado.descripcion;
                ticketActual.fechaUltimaModificacion = DateTime.Now;
            }
            Update(ticketActual);
            
        }

        public void RegistrarMostrarTicket(Ticket ticket)
        {
            InteraccionTicket interaccion = new InteraccionTicket();
            interaccion.idTicket = ticket.Id;
            interaccion.fecha = DateTime.Now;
            interaccion.empleado = Session.GetSession().usuario.empleado;
            interaccion.motivo = "Visualizacion Ticket";
            interaccion.observacion = "";
            interaccion.accion = "Visualizacion Ticket";
            ticket.interacciones.Add(interaccion);
            interaccionBLL.Create(interaccion);

        }
        
    }
}
