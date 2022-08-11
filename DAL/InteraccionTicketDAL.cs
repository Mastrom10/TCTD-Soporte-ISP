using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BE;
using SERV;

namespace DAL
{
    public class InteraccionTicketDAL : GenericDAL<InteraccionTicket>
    {
        EmpleadoDAL empleadoDAL;
        public InteraccionTicketDAL()
        {
            empleadoDAL = new EmpleadoDAL();
        }

        public override void Create(InteraccionTicket entity)
        {
            //CREAR_INTERACCION
            if (entity.Id == 0)
            {
                entity.Id = GetNextId();
            }
            SQLConnectionManager.getInstance().ExecuteProcedure("CREAR_INTERACCION", sqlParameters(entity));
        }

        public override void Delete(InteraccionTicket entity)
        {
            //BORRAR_INTERACCION
            SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_INTERACCION", sqlParameters(entity.Id));
        }

        public override List<InteraccionTicket> GetAll()
        {
            //OBTENER_TODOS_INTERACCION
            List<InteraccionTicket> interacciones = new List<InteraccionTicket>();

            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TODOS_INTERACCION");
            foreach (DataRow row in datatable.Rows)
            {
                interacciones.Add(mapToInteraccion(row));
            }
            return interacciones;
        }

        public override InteraccionTicket GetById(int id)
        {
            //OBTENER_POR_ID_INTERACCION
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_POR_ID_INTERACCION", sqlParameters(id));
            if (datatable.Rows.Count > 0)
            {
                return mapToInteraccion(datatable.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public override int GetNextId()
        {
            //OBTENER_MAX_ID_INTERACCION
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_MAX_ID_INTERACCION");
            int id = 0;
            foreach (DataRow row in datatable.Rows)
            {
                if (row["id"] != DBNull.Value)
                {
                    id = Convert.ToInt32(row["id"]);
                }
                else
                {
                    id = 0;
                }
            }
            return id + 1;
        }

        private InteraccionTicket mapToInteraccion(DataRow row) {
            /*  @id INT, @accion VARCHAR(200) = NULL, 
                @motivo VARCHAR(200) = NULL, @observacion VARCHAR(2000) = NULL, 
                @fecha DATETIME = NULL, @FK_id_empleado INT = NULL, @FK_id_ticket INT = NULL
            */
            if (row == null)
            {
                return null;
            }
            InteraccionTicket interaccion = new InteraccionTicket();
            interaccion.Id = int.Parse(row["id"].ToString());
            if (row["accion"] != DBNull.Value)
            {
                interaccion.accion = row["accion"].ToString();
            }
            if (row["motivo"] != DBNull.Value)
            {
                interaccion.motivo = row["motivo"].ToString();
            }
            if (row["observacion"] != DBNull.Value)
            {
                interaccion.observacion = row["observacion"].ToString();
            }
            if (row["fecha"] != DBNull.Value)
            {
                interaccion.fecha = DateTime.Parse(row["fecha"].ToString());
            }
            if (row["FK_id_empleado"] != DBNull.Value)
            {
                interaccion.empleado = empleadoDAL.GetById(int.Parse(row["FK_id_empleado"].ToString()));
            }
            if (row["FK_id_ticket"] != DBNull.Value)
            {
                interaccion.idTicket = int.Parse(row["FK_id_ticket"].ToString());
            }
            return interaccion;




        }        
        public override SqlParameter[] sqlParameters(InteraccionTicket entity)
        {
            /*  @id INT, @accion VARCHAR(200) = NULL, 
                @motivo VARCHAR(200) = NULL, @observacion VARCHAR(2000) = NULL, 
                @fecha DATETIME = NULL, @FK_id_empleado INT = NULL, @FK_id_ticket INT = NULL
            */
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@id", entity.Id);
            parameters[0].DbType = DbType.Int32;
            parameters[1] = new SqlParameter("@accion", entity.accion);
            parameters[1].DbType = DbType.String;
            parameters[2] = new SqlParameter("@motivo", entity.motivo);
            parameters[2].DbType = DbType.String;
            parameters[3] = new SqlParameter("@observacion", entity.observacion);
            parameters[3].DbType = DbType.String;
            if (entity.fecha != null && entity.fecha != DateTime.MinValue)
            {
                parameters[4] = new SqlParameter("@fecha", entity.fecha);
                parameters[4].DbType = System.Data.DbType.DateTime;
            }
            else
            {
                parameters[4] = new SqlParameter("@fecha", DBNull.Value);
            }
            parameters[5] = new SqlParameter("@FK_id_empleado", entity.empleado.Id);
            parameters[5].DbType = DbType.Int32;
            parameters[6] = new SqlParameter("@FK_id_ticket", entity.idTicket);
            return parameters;


        }

        public SqlParameter[] sqlParameters(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", id);
            parameters[0].DbType = DbType.Int32;
            return parameters;
        }

        public SqlParameter[] sqlParameters(string texto)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@texto", texto);
            parameters[0].DbType = DbType.String;
            return parameters;
        }
        public List<InteraccionTicket> GetAllByTicketID(int id)
        {
            //OBTENER_INTERACCION_POR_ID_TICKET
            List<InteraccionTicket> interacciones = new List<InteraccionTicket>();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_INTERACCION_POR_ID_TICKET", sqlParameters(id));
            foreach (DataRow row in datatable.Rows)
            {
                interacciones.Add(mapToInteraccion(row));
            }
            return interacciones;
        }

        public List<InteraccionTicket> GetAllByTicket(Ticket ticket)
        {
            return GetAllByTicketID(ticket.Id);
        }
        public override void Update(InteraccionTicket entity)
        {
            //ACTUALIZAR_INTERACCION
            SQLConnectionManager.getInstance().ExecuteProcedure("ACTUALIZAR_INTERACCION", sqlParameters(entity));
        }
    }
}
