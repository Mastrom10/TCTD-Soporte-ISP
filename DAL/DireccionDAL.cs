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
    public class DireccionDAL : GenericDAL<Direccion>
    {
        NodoRedDAL nodoRedDAL;
        public DireccionDAL()
        {
            nodoRedDAL = new NodoRedDAL();
        }
        public override void Create(Direccion entity)
        {
            //CREAR_DIRECCION
            if (entity.Id == 0)
            {
                entity.Id = GetNextId();
            }
            SQLConnectionManager.getInstance().ExecuteProcedure("CREAR_DIRECCION", sqlParameters(entity));
        }

        public override void Delete(Direccion entity)
        {
            //BORRAR_DIRECCION
            SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_DIRECCION", sqlParameters(entity));
        }

        public override List<Direccion> GetAll()
        {
            //OBTENER_TODOS_DIRECCION
            List<Direccion> direcciones = new List<Direccion>();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TODOS_DIRECCION");
            foreach (DataRow row in datatable.Rows)
            {
                direcciones.Add(mapToDireccion(row));
            }
            return direcciones;
        }

        public override Direccion GetById(int id)
        {
            //OBTENER_POR_ID_DIRECCION
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_POR_ID_DIRECCION", sqlParameters(id));
            if (datatable.Rows.Count > 0)
            {
                return mapToDireccion(datatable.Rows[0]);
            }
            else {
                return null;
            }
        }

        
        public override int GetNextId()
        {
            //OBTENER_MAX_ID_DIRECCION
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_MAX_ID_DIRECCION");
            if (datatable.Rows.Count > 0)
            {
                return int.Parse(datatable.Rows[0]["id"].ToString()) + 1;
            }
            else
            {
                return 1;
            }
        }

        public override SqlParameter[] sqlParameters(Direccion entity)
        {
            /* @id INT,
                @calle VARCHAR(200),
                @altura VARCHAR(50),
                @codigoPostal VARCHAR(50) = NULL,
                @localidad VARCHAR(50) = NULL,
                @provincia VARCHAR(50) = NULL,
                @depto VARCHAR(50) = NULL,
                @piso VARCHAR(50) = NULL,
                @FK_id_nodoRed INT = NULL
            */
            SqlParameter[] parametros = new SqlParameter[9];
            parametros[0] = new SqlParameter("@id", entity.Id);
            parametros[0].DbType = System.Data.DbType.Int32;
            parametros[1] = new SqlParameter("@calle", entity.calle);
            parametros[1].DbType = System.Data.DbType.String;
            parametros[2] = new SqlParameter("@altura", entity.altura);
            parametros[2].DbType = System.Data.DbType.String;
            parametros[3] = new SqlParameter("@codigoPostal", entity.codigoPostal);
            parametros[3].DbType = System.Data.DbType.String;
            parametros[4] = new SqlParameter("@localidad", entity.localidad);
            parametros[4].DbType = System.Data.DbType.String;
            parametros[5] = new SqlParameter("@provincia", entity.provincia);
            parametros[5].DbType = System.Data.DbType.String;
            parametros[6] = new SqlParameter("@depto", entity.depto);
            parametros[6].DbType = System.Data.DbType.String;
            parametros[7] = new SqlParameter("@piso", entity.piso);
            parametros[7].DbType = System.Data.DbType.String;
            parametros[8] = new SqlParameter("@FK_id_nodoRed", entity.nodoRed?.Id ?? null);
            parametros[8].DbType = System.Data.DbType.Int32;
            return parametros;
        }


        public override void Update(Direccion entity)
        {
            //ACTUALIZAR_DIRECCION
            SQLConnectionManager.getInstance().ExecuteProcedure("ACTUALIZAR_DIRECCION", sqlParameters(entity));
        }

        public Direccion GetByCliente(Cliente cliente) {
            //OBTENER_POR_ID_CLIENTE
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_DIRECCION_POR_ID_CLIENTE", sqlParameters(cliente.Id));
            if (datatable.Rows.Count > 0)
            {
                return mapToDireccion(datatable.Rows[0]);
            }
            else
            {
                return null;
            }
        }
        Direccion mapToDireccion(DataRow row)
        {
            Direccion direccion = new Direccion();
            direccion.Id = int.Parse(row["id"].ToString());
            direccion.calle = row["calle"].ToString();
            direccion.altura = row["altura"].ToString();

            if (row["piso"] != DBNull.Value)
            {
                direccion.piso = row["piso"].ToString();
            }

            if (row["depto"] != DBNull.Value)
            {
                direccion.depto = row["depto"].ToString();
            }

            if (row["localidad"] != DBNull.Value)
            {
                direccion.localidad = row["localidad"].ToString();
            }

            if (row["provincia"] != DBNull.Value)
            {
                direccion.provincia = row["provincia"].ToString();
            }

            if (row["codigoPostal"] != DBNull.Value)
            {
                direccion.codigoPostal = row["codigoPostal"].ToString();
            }

            if (row["FK_id_nodoRed"] != DBNull.Value)
            {
                direccion.nodoRed = nodoRedDAL.GetById(int.Parse(row["FK_id_nodoRed"].ToString()));
            }

            return direccion;
        }

        public SqlParameter[] sqlParameters(int id)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@id", id);
            parametros[0].DbType = System.Data.DbType.Int32;
            return parametros;
        }


    }

}
