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
    public class OrdenTecnicaDAL : GenericDAL<OrdenTecnica>
    {
        public override void Create(OrdenTecnica entity)
        {
            
            //CREAR_ORDEN_TECNICA
            if (entity.Id == 0)
            {
                entity.Id = GetNextId();
            }
            SQLConnectionManager.getInstance().ExecuteProcedure("CREAR_ORDEN_TECNICA", sqlParameters(entity));

        }

        public override void Delete(OrdenTecnica entity)
        {
            //BORRAR_ORDEN_TECNICA
            SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_ORDEN_TECNICA", sqlParameters(entity));
        }

        public override List<OrdenTecnica> GetAll()
        {
            //OBTENER_TODOS_ORDEN_TECNICA
            List<OrdenTecnica> OrdenTecnicas = new List<OrdenTecnica>();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TODOS_ORDEN_TECNICA");
            foreach (DataRow row in datatable.Rows)
            {
                OrdenTecnicas.Add(mapToOrdenTecnica(row));
            }
            return OrdenTecnicas;
        }

        public override OrdenTecnica GetById(int id)
        {
            //OBTENER_POR_ID_ORDEN_TECNICA
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_POR_ID_ORDEN_TECNICA", sqlParameters(id));
            if (datatable.Rows.Count > 0)
            {
                return mapToOrdenTecnica(datatable.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public override int GetNextId()
        {
            //OBTENER_MAX_ID_ORDEN_TECNICA
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_MAX_ID_ORDEN_TECNICA");
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

        public override SqlParameter[] sqlParameters(OrdenTecnica entity)
        {
            /* 
               @id INT,
               @tipoOrdenTecnica  VARCHAR(50),
               @notas  VARCHAR(5000),
               @FK_id_turno INT,
               @FK_id_ticket INT
           */
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("@id", entity.Id);
            parametros[0].DbType = DbType.Int32;

            parametros[1] = new SqlParameter("@tipoOrdenTecnica", entity.tipoOrdenTecnica);
            parametros[1].DbType = DbType.String;

            if (entity.notas != null)
            {
                parametros[2] = new SqlParameter("@notas", entity.notas);
                parametros[2].DbType = DbType.String;
            }
            else
            {
                parametros[2] = new SqlParameter("@notas", DBNull.Value);
                parametros[2].DbType = DbType.String;
            }

            if (entity.turno != null)
            {
                parametros[3] = new SqlParameter("@FK_id_turno", entity.turno.Id);
                parametros[3].DbType = DbType.Int32;
            }
            else
            {
                parametros[3] = new SqlParameter("@FK_id_turno", DBNull.Value);
                parametros[3].DbType = DbType.Int32;
            }

            if (entity.ticket != null)
            {
                parametros[4] = new SqlParameter("@FK_id_ticket", entity.ticket.Id);
                parametros[4].DbType = DbType.Int32;
            }
            else
            {
                parametros[4] = new SqlParameter("@FK_id_ticket", DBNull.Value);
                parametros[4].DbType = DbType.Int32;
            }
            
            return parametros;

        }


        public override void Update(OrdenTecnica entity)
        {
            //ACTUALIZAR_ORDEN_TECNICA
            SQLConnectionManager.getInstance().ExecuteProcedure("ACTUALIZAR_ORDEN_TECNICA", sqlParameters(entity));
            
        }


        public SqlParameter[] sqlParameters(int id)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@id", id);
            parametros[0].DbType = DbType.Int32;
            return parametros;
        }

        public SqlParameter[] sqlParameters(string texto)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@texto", texto);
            parametros[0].DbType = DbType.String;
            return parametros;
        }

        OrdenTecnica mapToOrdenTecnica(DataRow row)
        {
            OrdenTecnica ordenTecnica = new OrdenTecnica();
            ordenTecnica.Id = Convert.ToInt32(row["id"]);
            ordenTecnica.tipoOrdenTecnica = (TipoOrdenTecnica)Enum.Parse(typeof(TipoOrdenTecnica), row["tipoOrdenTecnica"].ToString());
            ordenTecnica.notas = row["notas"].ToString();
            ordenTecnica.turno = new TurnoDAL().GetById(Convert.ToInt32(row["FK_id_turno"]));
            ordenTecnica.ticket = new TicketDAL().GetById(Convert.ToInt32(row["FK_id_ticket"]));
            return ordenTecnica;
        }
        
        public OrdenTecnica GetByIdTicket(int FK_id_ticket)
        {
            //OBTENER_ORDEN_TECNICA_POR_ID_TICKET
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_ORDEN_TECNICA_POR_ID_TICKET", sqlParameters(FK_id_ticket));
            if (datatable.Rows.Count > 0)
            {
                return mapToOrdenTecnica(datatable.Rows[0]);
            }
            else
            {
                return null;
            }
        }


        public OrdenTecnica GetByIdTurno(int FK_id_turno)
        {
            //OBTENER_ORDEN_TECNICA_POR_ID_TURNO
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_ORDEN_TECNICA_POR_ID_TURNO", sqlParameters(FK_id_turno));
            if (datatable.Rows.Count > 0)
            {
                return mapToOrdenTecnica(datatable.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public  List<OrdenTecnica> GetAllByTipo(TipoOrdenTecnica tipoOrdenTecnica)
        {
            //OBTENER_ORDEN_TECNICA_POR_TIPO
            string tipo = tipoOrdenTecnica.ToString();
            List<OrdenTecnica> OrdenTecnicas = new List<OrdenTecnica>();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_ORDEN_TECNICA_POR_TIPO", sqlParameters(tipo));
            foreach (DataRow row in datatable.Rows)
            {
                OrdenTecnicas.Add(mapToOrdenTecnica(row));
            }
            return OrdenTecnicas;
        }

    }
}
