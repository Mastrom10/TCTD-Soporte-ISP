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
    public class ClienteDAL : GenericDAL<Cliente>
    {
        ServicioDAL servicioDAL;
        DireccionDAL direccionDAL;
        public ClienteDAL()
        {
            servicioDAL = new ServicioDAL();
            direccionDAL = new DireccionDAL();
        }

        public override void Create(Cliente entity)
        {
            //CREAR_CLIENTE
            if (entity.Id == 0)
            {
                entity.Id = GetNextId();
            }
            if (entity.direccion.Id == 0)
            {
                direccionDAL.Create(entity.direccion);
            }
            else {
                direccionDAL.Update(entity.direccion);
            }
            if (entity.servicio.Id == 0)
            {
                servicioDAL.Create(entity.servicio);
            }
            else {
                servicioDAL.Update(entity.servicio);
            }
            SQLConnectionManager.getInstance().ExecuteProcedure("CREAR_CLIENTE", sqlParameters(entity));

        }

        public override void Delete(Cliente entity)
        {
            //BORRAR_CLIENTE
            SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_CLIENTE", sqlParameters(entity));

        }

        public override List<Cliente> GetAll()
        {
            //OBTENER_TODOS_CLIENTE
            List<Cliente> clientes = new List<Cliente>();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TODOS_CLIENTE");
            foreach (DataRow row in datatable.Rows)
            {
                clientes.Add(mapToClient(row));
            }
            return clientes;
        }

        public override Cliente GetById(int id)
        {
            //OBTENER_POR_ID_CLIENTE
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_POR_ID_CLIENTE", sqlParameters(id));
            if (datatable.Rows.Count > 0)
            {
                return mapToClient(datatable.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public override int GetNextId()
        {
            //OBTENER_MAX_ID_CLIENTE
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_MAX_ID_CLIENTE");
            if (datatable.Rows.Count > 0)
            {
                return int.Parse(datatable.Rows[0]["id"].ToString()) + 1;
            }
            else
            {
                return 1;
            }
        }

        public Cliente GetByDni(string dni) {
            //OBTENER_CLIENTE_POR_DNI
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_CLIENTE_POR_DNI", sqlParameters(dni));
            if (datatable.Rows.Count > 0)
            {
                return mapToClient(datatable.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public override SqlParameter[] sqlParameters(Cliente entity)
        {
            //@id INT, @nombre VARCHAR(50) = NULL, @apellido VARCHAR(50)  = NULL, @dni VARCHAR(50)  = NULL, @telefonoPrincipal VARCHAR(50)  = NULL, @telefonoSecundario VARCHAR(50)  = NULL, @email VARCHAR(50)  = NULL, @FK_id_direccion INT  = NULL, @FK_id_servicio INT  = NULL, @fechaNacimiento DATE  = NULL
            SqlParameter[] parametros = new SqlParameter[10];
                parametros[0] = new SqlParameter("@id", entity.Id);
                parametros[0].DbType = DbType.Int32;
                parametros[1] = new SqlParameter("@nombre", entity.nombre);
                parametros[1].DbType = DbType.String;
                parametros[2] = new SqlParameter("@apellido", entity.apellido);
                parametros[2].DbType = DbType.String;
                parametros[3] = new SqlParameter("@dni", entity.dni);
                parametros[3].DbType = DbType.String;
                parametros[4] = new SqlParameter("@telefonoPrincipal", entity.telefonoPrincipal);
                parametros[4].DbType = DbType.String;
                parametros[5] = new SqlParameter("@telefonoSecundario", entity.telefonoSecundario);
                parametros[5].DbType = DbType.String;
                parametros[6] = new SqlParameter("@email", entity.email);
                parametros[6].DbType = DbType.String;
                parametros[7] = new SqlParameter("@FK_id_direccion", entity.direccion?.Id ?? null);
                parametros[7].DbType = DbType.Int32;
                parametros[8] = new SqlParameter("@FK_id_servicio", entity.servicio?.Id ?? null);
                parametros[8].DbType = DbType.Int32;
                parametros[9] = new SqlParameter("@fechaNacimiento", entity.fechaDeNacimiento);
                parametros[9].DbType = DbType.Date;
            return parametros;
        }

        public SqlParameter[] sqlParameters(int id)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@id", id);
            parametros[0].DbType = DbType.Int32;
            return parametros;
        }
        public SqlParameter[] sqlParameters(string cadena)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@cadena", cadena);
            parametros[0].DbType = DbType.String;
            return parametros;
        }


        public override void Update(Cliente entity)
        {
            //ACTUALIZAR_SERVICIO
            direccionDAL.Update(entity.direccion);
            servicioDAL.Update(entity.servicio);
            SQLConnectionManager.getInstance().ExecuteProcedure("ACTUALIZAR_CLIENTE", sqlParameters(entity));

        }

        Cliente mapToClient(DataRow row) {
            if (row == null)
            {
                return null;
            }
            //@id INT, @nombre VARCHAR(50) = NULL, @apellido VARCHAR(50)  = NULL, @dni VARCHAR(50)  = NULL, @telefonoPrincipal VARCHAR(50)  = NULL, @telefonoSecundario VARCHAR(50)  = NULL, @email VARCHAR(50)  = NULL, @FK_id_direccion INT  = NULL, @FK_id_servicio INT  = NULL, @fechaNacimiento DATE  = NULL
            Cliente cliente = new Cliente();
            cliente.Id = int.Parse(row["id"].ToString());
            if (row["nombre"] != DBNull.Value)
            {
                cliente.nombre = row["nombre"].ToString();
            }
            if (row["apellido"] != DBNull.Value)
            {
                cliente.apellido = row["apellido"].ToString();
            }
            if (row["dni"] != DBNull.Value)
            {
                cliente.dni = row["dni"].ToString();
            }
            if (row["telefonoPrincipal"] != DBNull.Value)
            {
                cliente.telefonoPrincipal = row["telefonoPrincipal"].ToString();
            }
            if (row["telefonoSecundario"] != DBNull.Value)
            {
                cliente.telefonoSecundario = row["telefonoSecundario"].ToString();
            }
            if (row["email"] != DBNull.Value)
            {
                cliente.email = row["email"].ToString();
            }
            if (row["FK_id_direccion"] != DBNull.Value)
            {
                cliente.direccion = direccionDAL.GetById(int.Parse(row["FK_id_direccion"].ToString()));
            }
            if (row["FK_id_servicio"] != DBNull.Value)
            {
                cliente.servicio = servicioDAL.GetById(int.Parse(row["FK_id_servicio"].ToString()));
            }
            if (row["fechaNacimiento"] != DBNull.Value)
            {
                cliente.fechaDeNacimiento = DateTime.Parse(row["fechaNacimiento"].ToString());
            }
            return cliente;
        }
    }
}
