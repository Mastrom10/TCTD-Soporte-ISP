using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;


namespace DAL
{
    public class TicketDAL : GenericDAL<Ticket>
    {

        ClienteDAL clienteDAL;
        EmpleadoDAL empleadoDAL;
        InteraccionTicketDAL interaccionTicketDAL;
        public TicketDAL()
        {
            clienteDAL = new ClienteDAL();
            empleadoDAL = new EmpleadoDAL();
            interaccionTicketDAL = new InteraccionTicketDAL();
        }
        
        public override void Create(Ticket entity)
        {
            if (entity.Id == 0)
            {
                entity.Id = GetNextId();
            }
            SQLConnectionManager.getInstance().ExecuteProcedure("CREAR_TICKET", sqlParameters(entity));
        }

        public override void Delete(Ticket entity)
        {
            //BORRAR_TICKET
            SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_TICKET", sqlParameters(entity));

        }

        public override List<Ticket> GetAll()
        {
            //OBTENER_TODOS_TICKET
            List<Ticket> tickets = new List<Ticket>();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TODOS_TICKET");
            foreach (DataRow row in datatable.Rows)
            {
                tickets.Add(mapToTicket(row));
            }
            return tickets;
        }

        private Ticket mapToTicket(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            Ticket ticket = new Ticket();
            /* @id INT, 
            * @titulo VARCHAR(200),
            * @descripcion VARCHAR(2000) = NULL, 
            * @estado VARCHAR(50), 
            * @prioridad VARCHAR(50), 
            * @fechaCreacion DATETIME,
            * @fechaUltimaModificacion DATETIME, 
            * @fechaCierre DATETIME = NULL, 
            * @FK_id_cliente INT, 
            * @FK_id_empleado INT
            */
            ticket.Id = int.Parse(row["id"].ToString());
            if (row["titulo"] != DBNull.Value)
            {
                ticket.titulo = row["titulo"].ToString();
            }
            if (row["descripcion"] != DBNull.Value)
            {
                ticket.descripcion = row["descripcion"].ToString();
            }
            if (row["estado"] != DBNull.Value)
            {
                ticket.estado = (EstadoTicket)Enum.Parse(typeof(EstadoTicket), row["estado"].ToString());
            }
            if (row["prioridad"] != DBNull.Value)
            {
                ticket.prioridad = (PrioridadTicket)Enum.Parse(typeof(PrioridadTicket), row["prioridad"].ToString());
            }
            if (row["fechaCreacion"] != DBNull.Value)
            {
                ticket.fechaCreacion = DateTime.Parse(row["fechaCreacion"].ToString());
            }
            if (row["fechaUltimaModificacion"] != DBNull.Value)
            {
                ticket.fechaUltimaModificacion = DateTime.Parse(row["fechaUltimaModificacion"].ToString());
            }
            if (row["fechaCierre"] != DBNull.Value)
            {
                ticket.fechaCierre = DateTime.Parse(row["fechaCierre"].ToString());
            }
            if (row["FK_id_cliente"] != DBNull.Value)
            {
                ticket.cliente = clienteDAL.GetById(int.Parse(row["FK_id_cliente"].ToString()));
            }
            if (row["FK_id_empleado"] != DBNull.Value)
            {
                ticket.empleado = empleadoDAL.GetById(int.Parse(row["FK_id_empleado"].ToString()));
            }
            ticket.interacciones = interaccionTicketDAL.GetAllByTicketID(ticket.Id);
            return ticket;

        }

        public override Ticket GetById(int id)
        {
            //OBTENER_POR_ID_TICKET
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_POR_ID_TICKET", sqlParameters(id));
            if (datatable.Rows.Count > 0)
            {
                return mapToTicket(datatable.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public List<Ticket> GetByCliente(Cliente cliente)
        {
            //OBTENER_TICKET_POR_ID_CLIENTE
            List<Ticket> tickets = new List<Ticket>();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TICKET_POR_ID_CLIENTE", sqlParameters(cliente.Id));
            foreach (DataRow row in datatable.Rows)
            {
                tickets.Add(mapToTicket(row));
            }
            return tickets;
        }
        
        public override int GetNextId()
        {
            //OBTENER_MAX_ID_TICKET
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_MAX_ID_TICKET");
            int id = 0;
            foreach (DataRow row in datatable.Rows)
            {
                if (row["Id"] != DBNull.Value)
                {
                    id = Convert.ToInt32(row["Id"]);
                }
                else
                {
                    id = 0;
                }
            }
            return id + 1;
        }

        public override SqlParameter[] sqlParameters(Ticket entity)
        {
            /* @id INT, 
             * @titulo VARCHAR(200),
             * @descripcion VARCHAR(2000) = NULL, 
             * @estado VARCHAR(50), 
             * @prioridad VARCHAR(50), 
             * @fechaCreacion DATETIME,
             * @fechaUltimaModificacion DATETIME, 
             * @fechaCierre DATETIME = NULL, 
             * @FK_id_cliente INT, 
             * @FK_id_empleado INT
             */
            SqlParameter[] parameters = new SqlParameter[10];
            parameters[0] = new SqlParameter("@id", entity.Id);
            parameters[0].DbType = System.Data.DbType.Int32;
            parameters[1] = new SqlParameter("@titulo", entity.titulo);
            parameters[1].DbType = System.Data.DbType.String;
            parameters[2] = new SqlParameter("@descripcion", entity.descripcion);
            parameters[2].DbType = System.Data.DbType.String;
            parameters[3] = new SqlParameter("@estado", entity.estado);
            parameters[3].DbType = System.Data.DbType.String;
            parameters[4] = new SqlParameter("@prioridad", entity.prioridad);
            parameters[4].DbType = System.Data.DbType.String;
            if (entity.fechaCreacion != null && entity.fechaCreacion != DateTime.MinValue)
            {
                parameters[5] = new SqlParameter("@fechaCreacion", entity.fechaCreacion);
                parameters[5].DbType = System.Data.DbType.DateTime;
            }
            else
            {
                parameters[5] = new SqlParameter("@fechaCreacion", DBNull.Value);
            }
            if (entity.fechaUltimaModificacion != null && entity.fechaUltimaModificacion != DateTime.MinValue)
            {
                parameters[6] = new SqlParameter("@fechaUltimaModificacion", entity.fechaUltimaModificacion);
                parameters[6].DbType = System.Data.DbType.DateTime;
            }
            else
            {
                parameters[6] = new SqlParameter("@fechaUltimaModificacion", DBNull.Value);
            }
            if (entity.fechaCierre != null && entity.fechaCierre != DateTime.MinValue)
            {
                parameters[7] = new SqlParameter("@fechaCierre", entity.fechaCierre);
                parameters[7].DbType = System.Data.DbType.DateTime;
            }
            else
            {
                parameters[7] = new SqlParameter("@fechaCierre", DBNull.Value);
            }
            parameters[8] = new SqlParameter("@FK_id_cliente", entity.cliente.Id);
            parameters[8].DbType = System.Data.DbType.Int32;
            parameters[9] = new SqlParameter("@FK_id_empleado", entity.empleado.Id);
            parameters[9].DbType = System.Data.DbType.Int32;
            return parameters;



        }


        public  SqlParameter[] sqlParameters(int id)
        {

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", id);
            parameters[0].DbType = System.Data.DbType.Int32;
            return parameters;
        }
        public SqlParameter[] sqlParameters(string texto)
        {

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@texto", texto);
            parameters[0].DbType = System.Data.DbType.String;
            return parameters;
        }

        
        public override void Update(Ticket entity)
        {
            //ACTUALIZAR_TICKET
            SQLConnectionManager.getInstance().ExecuteProcedure("ACTUALIZAR_TICKET", sqlParameters(entity));
           
            //Actualizamos las Interacciones
            foreach (InteraccionTicket interaccion in entity.interacciones)
            {
                interaccionTicketDAL.Update(interaccion);
            }
        }
    }
}
