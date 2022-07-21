using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SERV.MultiIdioma; 

namespace DAL
{
    public class TraduccionDAL : GenericDAL<Traduccion>
    {
        public override void Create(Traduccion entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Traduccion entity)
        {
            throw new NotImplementedException();
        }

        public List<Traduccion> GetAllByIdioma(Idioma idioma)
        {
            DataTable dataTable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TRADUCCIONES_POR_IDIOMA", sqlParameters(idioma));
            List<Traduccion> traducciones = new List<Traduccion>();
            foreach (DataRow row in dataTable.Rows)
            {
                Traduccion traduccion = new Traduccion();
                Etiqueta etiqueta = new Etiqueta();
                etiqueta.Id = Convert.ToInt32(row["Id_Etiqueta"]);
                etiqueta.Nombre = row["NombreEtiqueta"].ToString();
                etiqueta.defaultText = row["defaultText"].ToString();
                traduccion.etiqueta = etiqueta;
                traduccion.idioma = idioma;
                traduccion.traduccion = row["Traduccion"].ToString();
                traducciones.Add(traduccion);
            }
            return traducciones;
        }

        public override List<Traduccion> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Traduccion GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override int GetNextId()
        {
            throw new NotImplementedException();
        }

        public override SqlParameter[] sqlParameters(Traduccion entity)
        {
            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = new SqlParameter("@Id_Etiqueta", entity.etiqueta.Id);
            parametros[0].DbType = System.Data.DbType.Int32;
            parametros[1] = new SqlParameter("@Id_Idioma", entity.idioma.Id);
            parametros[1].DbType = System.Data.DbType.Int32;
            parametros[2] = new SqlParameter("@Traduccion", entity.traduccion);
            parametros[2].DbType = System.Data.DbType.String;
            return parametros;
        }

        private SqlParameter[] sqlParameters(Idioma idioma)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@Id", idioma.Id);
            parametros[0].DbType = System.Data.DbType.Int32;
            parametros[1] = new SqlParameter("@Nombre_Idioma", idioma.Nombre);
            parametros[1].DbType = System.Data.DbType.String;
            return parametros;
        }

        public override void Update(Traduccion entity)
        {
            SQLConnectionManager.getInstance().ExecuteProcedure("UPDATE_TRADUCCIONES", sqlParameters(entity));
        }
    }
}
