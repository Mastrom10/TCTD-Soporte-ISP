using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BE;

namespace DAL
{
    public class EmpleadoDAL : GenericDAL<Empleado>
    {

        SqlParameter[] sqlParametersEmpleado(Empleado empleado)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter paramNombre = new SqlParameter("@Nombre", empleado.Nombre);
            paramNombre.DbType = DbType.String;
            parameters.Add(paramNombre);

            SqlParameter paramApellido = new SqlParameter("@Apellido", empleado.Apellido);
            paramApellido.DbType = DbType.String;
            parameters.Add(paramApellido);

            SqlParameter paramNumeroRepresentante = new SqlParameter("@NumeroRepresentante", empleado.NumeroRepresentante);
            paramNumeroRepresentante.DbType = DbType.Int32;
            parameters.Add(paramNumeroRepresentante);

            SqlParameter TipoEmpleado = new SqlParameter("@TipoEmpleado", empleado.TipoEmpleado);
            TipoEmpleado.DbType = DbType.Int32;
            parameters.Add(TipoEmpleado);

            if (empleado.Id != 0)
            {
                SqlParameter paramId = new SqlParameter("@Id", empleado.Id);
                paramId.DbType = DbType.Int32;
                parameters.Add(paramId);
            }

            return parameters.ToArray();
        }

        public override void Create(Empleado entity)
        {
            if (entity.Id == 0)
            {
                entity.Id = GetNextId();
            }
            SQLConnectionManager.getInstance().ExecuteProcedure("CREAR_EMPLEADO", sqlParametersEmpleado(entity));
        }

        public override void Delete(Empleado entity)
        {
            SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_EMPLEADO", sqlParametersEmpleado(entity));
        }

        public override List<Empleado> GetAll()
        {
            //public DataTable ExecuteProcedureDataTable(string procedure)
            DataTable dataTable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TODOS_EMPLEADOS");
            List<Empleado> empleados = new List<Empleado>();
            foreach (DataRow row in dataTable.Rows)
            {
                Empleado empleado = new Empleado();
                empleado.Id = Convert.ToInt32(row["Id"]);
                empleado.Nombre = row["Nombre"].ToString();
                empleado.Apellido = row["Apellido"].ToString();
                empleado.NumeroRepresentante = Convert.ToInt32(row["NumeroRepresentante"]);
                empleado.TipoEmpleado = (TipoEmpleado)Convert.ToInt32(row["FK_id_TipoEmpleado"]);
                empleados.Add(empleado);
            }
            return empleados;
            
        }

        public override Empleado GetById(int id)
        {
            SqlParameter paramId = new SqlParameter("@Id", id);
            paramId.DbType = DbType.Int32;
            SqlParameter[] parameters = new SqlParameter[] { paramId };

            DataTable dataTable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_EMPLEADO_POR_ID", parameters);
            Empleado empleado = new Empleado();
            foreach (DataRow row in dataTable.Rows)
            {
                empleado.Id = Convert.ToInt32(row["Id"]);
                empleado.Nombre = row["Nombre"].ToString();
                empleado.Apellido = row["Apellido"].ToString();
                empleado.NumeroRepresentante = Convert.ToInt32(row["NumeroRepresentante"]);
                empleado.TipoEmpleado = (TipoEmpleado)Convert.ToInt32(row["FK_id_TipoEmpleado"]);
            }
            return empleado;
        }

        public override int GetNextId()
        {
            DataTable dataTable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_MAX_ID_EMPLEADO");
            int id = 0;
            foreach (DataRow row in dataTable.Rows)
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
            return id + 1 ;
        }

        public override void Update(Empleado entity)
        {
            SQLConnectionManager.getInstance().ExecuteProcedure("ACTUALIZAR_EMPLEADO", sqlParametersEmpleado(entity));
        }
    }
}
