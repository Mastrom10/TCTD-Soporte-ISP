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
    public class ServicePlanDAL : GenericDAL<ServicePlan>
    {
        public override void Create(ServicePlan entity)
        {
            if (entity.Id == 0)
            {
                entity.Id = GetNextId();
            }
            SQLConnectionManager.getInstance().ExecuteProcedure("CREAR_SERVICEPLAN", sqlParameters(entity));
            
        }

        public override void Delete(ServicePlan entity)
        {
            //BORRAR_SERVICEPLAN
            SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_SERVICEPLAN", sqlParameters(entity));
            
        }

        public override List<ServicePlan> GetAll()
        {
            //OBTENER_TODOS_SERVICEPLAN
            List<ServicePlan> servicePlans = new List<ServicePlan>();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TODOS_SERVICEPLAN");
            foreach (DataRow row in datatable.Rows)
            {
                ServicePlan servicePlan = new ServicePlan();
                servicePlan.Id = int.Parse(row["id"].ToString());
                servicePlan.descripcion = row["descripcion"].ToString();
                servicePlans.Add(servicePlan);
            }
            return servicePlans;
        }

        public override ServicePlan GetById(int id)
        {
            //OBTENER_POR_ID_SERVICEPLAN
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_POR_ID_SERVICEPLAN", sqlParameters(id));
            ServicePlan servicePlan = new ServicePlan();
            foreach (DataRow row in datatable.Rows)
            {
                servicePlan.Id = int.Parse(row["id"].ToString());
                servicePlan.descripcion = row["descripcion"].ToString();
            }
            return servicePlan;
        }

        public override int GetNextId()
        {
            //OBTENER_MAX_ID_SERVICEPLAN
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_MAX_ID_SERVICEPLAN");
            int id = 0;
            try { 
                if (datatable.Rows.Count > 0)
                {
                    id = int.Parse(datatable.Rows[0]["id"].ToString());
                }
            }
            catch (Exception)
            {}
            return id + 1;
            
        }

        public override SqlParameter[] sqlParameters(ServicePlan entity)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@id", entity.Id);
            parametros[0].DbType = System.Data.DbType.Int32;
            parametros[1] = new SqlParameter("@descripcion", entity.descripcion);
            parametros[1].DbType = System.Data.DbType.String;
            return parametros;
        }
        public SqlParameter[] sqlParameters(int id)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@id", id);
            parametros[0].DbType = System.Data.DbType.Int32;
            return parametros;
        }

        public override void Update(ServicePlan entity)
        {
            //ACTUALIZAR_SERVICEPLAN
            SQLConnectionManager.getInstance().ExecuteProcedure("ACTUALIZAR_SERVICEPLAN", sqlParameters(entity));
            
        }
    }
}
