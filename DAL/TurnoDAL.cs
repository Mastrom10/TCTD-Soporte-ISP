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
    public class TurnoDAL : GenericDAL<Turno>
    {
        public override void Create(Turno entity)
        {
            if (entity.Id == 0)
            {
                entity.Id = GetNextId();
            }
            SQLConnectionManager.getInstance().ExecuteProcedure("CREAR_TURNO", sqlParameters(entity));

        }

        public List<Turno> GetTurnosByFechaRange(DateTime fechaDesde, DateTime fechaHasta)
        {
            //OBTENER_TURNOS_POR_RANGO_FECHAS
            List<Turno> turnos = new List<Turno>();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TURNOS_POR_RANGO_FECHAS", sqlParameters(fechaDesde, fechaHasta));

            foreach (DataRow row in datatable.Rows)
            {
                turnos.Add(mapToTurno(row));
            }   
            return turnos;


        }

        public override void Delete(Turno entity)
        {
            //BORRAR_TURNO
            SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_TURNO", sqlParameters(entity));
        }

        public override List<Turno> GetAll()
        {
            //OBTENER_TODOS_TURNO
            List<Turno> turnos = new List<Turno>();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TODOS_TURNO");
            foreach (DataRow row in datatable.Rows)
            {
                turnos.Add(mapToTurno(row));
            }
            return turnos;

        }

        public override Turno GetById(int id)
        {
            //OBTENER_POR_ID_TURNO
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_POR_ID_TURNO", sqlParameters(id));
            if (datatable.Rows.Count > 0)
            {
                return mapToTurno(datatable.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public override int GetNextId()
        {
            //OBTENER_MAX_ID_TURNO
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_MAX_ID_TURNO");
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

        public override SqlParameter[] sqlParameters(Turno entity)
        {
            //@id INT, @estadoTurno varchar(50), @fecha datetime, @franjaHoraria varchar(50)
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("@id", entity.Id);
            parametros[0].DbType = DbType.Int32;
            parametros[1] = new SqlParameter("@estadoTurno", entity.estadoTurno.ToString());
            parametros[1].DbType = DbType.String;
            if (entity.fecha != null && entity.fecha != DateTime.MinValue)
            {
                parametros[2] = new SqlParameter("@fecha", entity.fecha);
                parametros[2].DbType = DbType.DateTime;
            }
            else { 
                parametros[2] = new SqlParameter("@fecha", DBNull.Value);
            }
            parametros[3] = new SqlParameter("@franjaHoraria", entity.franjaHoraria.ToString());
            parametros[3].DbType = DbType.String;

            return parametros;
        }

        public  SqlParameter[] sqlParameters(int id)
        {
            //@id INT, @estadoTurno varchar(50), @fecha datetime, @franjaHoraria varchar(50)
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@id", id);
            parametros[0].DbType = DbType.Int32;
            return parametros;
        }

        public SqlParameter[] sqlParameters(DateTime fechaDesde, DateTime fechaHasta)
        {
            //@fechaDesde datetime, @fechaHasta datetime
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@fechaDesde", fechaDesde);
            parametros[0].DbType = DbType.DateTime;
            parametros[1] = new SqlParameter("@fechaHasta", fechaHasta);
            parametros[1].DbType = DbType.DateTime;
            return parametros;
        }

        private Turno mapToTurno(DataRow row)
        {
            //@id INT, @estadoTurno varchar(50), @fecha datetime, @franjaHoraria varchar(50)
            Turno turno = new Turno();
            turno.Id = Convert.ToInt32(row["id"]);
            turno.estadoTurno = (EstadoTurno)Enum.Parse(typeof(EstadoTurno), row["estadoTurno"].ToString());
            turno.fecha = Convert.ToDateTime(row["fecha"]);
            turno.franjaHoraria = (FranjaHoraria)Enum.Parse(typeof(FranjaHoraria), row["franjaHoraria"].ToString());
            return turno;
            
        }

        public override void Update(Turno entity)
        {
            //ACTUALIZAR_TURNO
            SQLConnectionManager.getInstance().ExecuteProcedure("ACTUALIZAR_TURNO", sqlParameters(entity));
        }
    }
}
