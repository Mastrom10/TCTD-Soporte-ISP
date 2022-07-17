using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERV.MultiIdioma;
namespace DAL
{
    public  class IdiomaDAL : GenericDAL<Idioma>
    {

        
        public override void Create(Idioma entity)
        {
            //SP CREAR_IDIOMA
            if (entity.Id == 0)
            { entity.Id = GetNextId();
            }

            SQLConnectionManager.getInstance().ExecuteProcedure("CREAR_IDIOMA", sqlParameters(entity));
        }

        public override void Delete(Idioma entity)
        {
            //BORRAR_IDIOMA
            SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_IDIOMA", sqlParameters(entity));

        }

        public override List<Idioma> GetAll()
        {
            //SP OBTENER_TODOS_IDIOMAS
            DataTable dataTable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TODOS_IDIOMAS");
            List<Idioma> idiomas = new List<Idioma>();
            foreach (DataRow row in dataTable.Rows)
            {
                idiomas.Add(new Idioma()
                {
                    Id = Convert.ToInt32(row["id"]),
                    Nombre = row["nombre"].ToString()
                });
            }
            return idiomas;
        }

        public override Idioma GetById(int id)
        {
            //OBTENER_IDIOMA_POR_ID
            DataTable dataTable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_IDIOMA_POR_ID", sqlParameters(id));
            if (dataTable.Rows.Count > 0)
            {
                return new Idioma()
                {
                    Id = Convert.ToInt32(dataTable.Rows[0]["id"]),
                    Nombre = dataTable.Rows[0]["nombre"].ToString()
                };
            }
            return null;
        }

        public override int GetNextId()
        {
            //OBTENER_MAX_ID_IDIOMA
            DataTable dataTable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_MAX_ID_IDIOMA");
            int id = 0;
            foreach (DataRow row in dataTable.Rows)
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

        public override SqlParameter[] sqlParameters(Idioma entity)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@Id", entity.Id);
            parametros[0].DbType = System.Data.DbType.Int32;
            parametros[1] = new SqlParameter("@Nombre", entity.Nombre);
            parametros[1].DbType = System.Data.DbType.String;
            return parametros;
        }

        private SqlParameter[] sqlParameters(int id) {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@Id", id);
            parametros[0].DbType = System.Data.DbType.Int32;
            return parametros;
        }

        public override void Update(Idioma entity)
        {
            //ACTUALIZAR_IDIOMA
            SQLConnectionManager.getInstance().ExecuteProcedure("ACTUALIZAR_IDIOMA", sqlParameters(entity));
            
        }
    }
}
