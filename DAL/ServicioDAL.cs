using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using SERV;


namespace DAL
{
    public class ServicioDAL : GenericDAL<Servicio>
    {
        ServicePlanDAL spDAL;
        DispositivoDAL dDAL;

        public ServicioDAL()
        {
            spDAL = new ServicePlanDAL();
            dDAL = new DispositivoDAL();
        }

        public override void Create(Servicio entity)
        {
            //CREAR_SERVICIO
            if (entity.Id == 0)
            {
                entity.Id = GetNextId();
            }
            SQLConnectionManager.getInstance().ExecuteProcedure("CREAR_SERVICIO", sqlParameters(entity));

        }

        public override void Delete(Servicio entity)
        {
            //BORRAR_SERVICIO
            SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_SERVICIO", sqlParameters(entity));

        }

        public override List<Servicio> GetAll()
        {
            //OBTENER_TODOS_SERVICIO
            List<Servicio> direcciones = new List<Servicio>();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TODOS_SERVICIO");
            foreach (DataRow row in datatable.Rows)
            {
                direcciones.Add(mapToServicio(row));
            }
            return direcciones;
        }

        public override Servicio GetById(int id)
        {
            //OBTENER_POR_ID_SERVICIO
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_POR_ID_SERVICIO", sqlParameters(id));
            if (datatable.Rows.Count > 0)
            {
                return mapToServicio(datatable.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public Servicio GetByCliente(Cliente cliente) {
            //OBTENER_SERVICIO_POR_CLIENTE
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_SERVICIO_POR_CLIENTE", sqlParameters(cliente.Id));
            if (datatable.Rows.Count > 0)
            {
                return mapToServicio(datatable.Rows[0]);
            }
            else
            {
                return null;
            }

        }
        

        public override int GetNextId()
        {
            //OBTENER_MAX_ID_SERVICIO
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_MAX_ID_SERVICIO");
            if (datatable.Rows.Count > 0)
            {
                return int.Parse(datatable.Rows[0]["id"].ToString()) + 1;
            }
            else
            {
                return 1;
            }
        }

        public override SqlParameter[] sqlParameters(Servicio entity)
        {
            //@id INT, @estado VARCHAR(50), @FK_id_ServicePlan INT
            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = new SqlParameter("@id", entity.Id);
            parametros[0].DbType = DbType.Int32;
            parametros[1] = new SqlParameter("@estado", entity.estado.ToString());
            parametros[1].DbType = DbType.String;
            parametros[2] = new SqlParameter("@FK_id_ServicePlan", entity.servicePlan?.Id ?? null);
            parametros[2].DbType = DbType.Int32;
            return parametros;
        }
        public SqlParameter[] sqlParameters(int id)
        {
            //@id INT, @estado VARCHAR(50), @FK_id_ServicePlan INT
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@id", id);
            parametros[0].DbType = DbType.Int32;
            return parametros;
        }        

        public override void Update(Servicio entity)
        {
            //ACTUALIZAR_SERVICIO
            SQLConnectionManager.getInstance().ExecuteProcedure("ACTUALIZAR_SERVICIO", sqlParameters(entity));

        }

        Servicio mapToServicio(DataRow row) {
            Servicio servicio = new Servicio();
            servicio.Id = int.Parse(row["id"].ToString());
            servicio.estado = (EstadoServicio)Enum.Parse(typeof(EstadoServicio), row["estado"].ToString());
            if (row["FK_id_ServicePlan"] != DBNull.Value)
            {
                servicio.servicePlan = spDAL.GetById(int.Parse(row["FK_id_ServicePlan"].ToString()));
            }
            servicio.dispositivos = dDAL.getByServicio(servicio);
            return servicio;
        }
    }
}
