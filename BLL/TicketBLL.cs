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
            if (!Session.GetSession().TienePermiso(this.permiso))
            {
                logger.Log("No tiene permiso para realizar esta accion", LogLevel.Warning, "Permiso Faltante: " + this.permiso.ToString(), this.GetType().ToString());
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + this.permiso.ToString());
            }

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
            logger.Log("Se ha creado el ticket " + ticket.Id, LogLevel.Info, SERV.Serializacion.LogSerializer.Serialize(ticket), this.GetType().ToString());

        }


        public List<Ticket> GetTicketsByCliente(Cliente cliente)
        {
            if (!Session.GetSession().TienePermiso(this.permiso))
            {
                logger.Log("No tiene permiso para realizar esta accion", LogLevel.Warning, "Permiso Faltante: " + this.permiso.ToString(), this.GetType().ToString());
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + this.permiso.ToString());
            }

            List<Ticket> tickets = ((TicketDAL)dal).GetByCliente(cliente);
            logger.Log("Se han obtenido los tickets del cliente " + cliente.Id, LogLevel.Debug, null, this.GetType().ToString());
            return tickets;
        }

        //getTicketsByEstado
        public List<Ticket> GetTicketsByEstado(EstadoTicket estado)
        {
            if (!Session.GetSession().TienePermiso(this.permiso))
            {
                logger.Log("No tiene permiso para realizar esta accion", LogLevel.Warning, "Permiso Faltante: " + this.permiso.ToString(), this.GetType().ToString());
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + this.permiso.ToString());
            }


            //return ((TicketDAL)dal).GetByEstado(estado);
            List<Ticket> tickets = ((TicketDAL)dal).GetByEstado(estado);
            logger.Log("Se han obtenido los tickets del estado " + estado.ToString(), LogLevel.Debug, SERV.Serializacion.LogSerializer.Serialize(tickets), this.GetType().ToString());
            return tickets;
        }

        public void Update(Ticket ticketActual, Ticket ticketActualizado)
        {
            if (!Session.GetSession().TienePermiso(this.permiso))
            {
                logger.Log("No tiene permiso para realizar esta accion", LogLevel.Warning, "Permiso Faltante: " + this.permiso.ToString(), this.GetType().ToString());
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + this.permiso.ToString());
            }


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
            if (!Session.GetSession().TienePermiso(this.permiso))
            {
                logger.Log("No tiene permiso para realizar esta accion", LogLevel.Warning, "Permiso Faltante: " + this.permiso.ToString(), this.GetType().ToString());
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + this.permiso.ToString());
            }
            
            InteraccionTicket interaccion = new InteraccionTicket();
            interaccion.idTicket = ticket.Id;
            interaccion.fecha = DateTime.Now;
            interaccion.empleado = Session.GetSession().usuario.empleado;
            interaccion.motivo = "Visualizacion Ticket";
            interaccion.observacion = "";
            interaccion.accion = "Visualizacion Ticket";
            ticket.interacciones.Add(interaccion);
            interaccionBLL.Create(interaccion);
            logger.Log("Se ha registrado la visualizacion del ticket " + ticket.Id, LogLevel.Debug, SERV.Serializacion.LogSerializer.Serialize(interaccion), this.GetType().ToString());

        }
        
    }
}
