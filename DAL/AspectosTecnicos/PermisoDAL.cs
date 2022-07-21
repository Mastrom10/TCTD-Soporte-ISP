using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERV.Composite;
using SERV;
using BE;

namespace DAL
{
    public class PermisoDAL : GenericDAL<Permiso>
    {

        public override SqlParameter[] sqlParameters(Permiso permiso) {
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("@Id", permiso.Id);
            parametros[0].DbType = System.Data.DbType.Int32;
            parametros[1] = new SqlParameter("@Nombre", permiso.Nombre);
            parametros[1].DbType = System.Data.DbType.String;
            
            //@Tipo
            if (permiso is Patente)
            {
                parametros[2] = new SqlParameter("@Tipo", ((Patente)permiso).Tipo);
                parametros[2].DbType = System.Data.DbType.String;
                parametros[3] = new SqlParameter("@esFamilia", 0);
                parametros[3].DbType = System.Data.DbType.Int32;
            }
            else if (permiso is Familia)
            {
                parametros[2] = new SqlParameter("@Tipo", "Group");
                parametros[2].DbType = System.Data.DbType.String;
                parametros[3] = new SqlParameter("@esFamilia", 1);
                parametros[3].DbType = System.Data.DbType.Int32;
            }

            return parametros;
        }
        private SqlParameter[] sqlParameters(Permiso padre, Permiso hijo)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@Id_Padre", padre.Id);
            parametros[0].DbType = System.Data.DbType.Int32;
            parametros[1] = new SqlParameter("@Id_Hijo", hijo.Id);
            parametros[1].DbType = System.Data.DbType.Int32;
            return parametros;

        }

        private SqlParameter[] sqlParameters(Usuario usuario, Permiso permiso) {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@Id_Usuario", usuario.Id);
            parametros[0].DbType = System.Data.DbType.Int32;
            parametros[1] = new SqlParameter("@Id_Permiso", permiso.Id);
            parametros[1].DbType = System.Data.DbType.Int32;
            return parametros;
        }


        private SqlParameter[] sqlParameters(int id) {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@Id", id);
            parametros[0].DbType = DbType.Int32;
            return parametros;
        }

        public override void Create(Permiso entity)
        {
            if (entity.Id == 0)
            {
                entity.Id = GetNextId();
            }
            SQLConnectionManager.getInstance().ExecuteProcedure("CREAR_PERMISO", sqlParameters(entity));
            if (entity is Familia) {
                foreach (Permiso permisoHijo in ((Familia)entity).ObtenerHijos())
                {
                    Create(permisoHijo);
                    SQLConnectionManager.getInstance().ExecuteProcedure("GUARDAR_PERMISO_HIJO", sqlParameters(entity, permisoHijo));
                }
            }

        }

        public override void Delete(Permiso entity)
        {
            if (entity is Familia)
            {
                foreach (Permiso permisoHijo in ((Familia)entity).ObtenerHijos())
                {
                    SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_PERMISO_HIJO", sqlParameters(entity, permisoHijo));
                }
            }
            SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_PERMISO_PADRE", sqlParameters(entity.Id));
            SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_PERMISO", sqlParameters(entity));

        }

        public void VincularPadreHijo(Familia padre, Permiso hijo)
        {

            if (SinLoop(padre, hijo))
            {
                try
                {
                    SQLConnectionManager.getInstance().ExecuteProcedure("GUARDAR_PERMISO_HIJO", sqlParameters(padre, hijo));

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY constraint"))
                    {
                        throw new Exception("El permiso ya se encuentra asignado al grupo", ex);
                    }

                    throw ex;
                }
            }
            else {
                throw new Exception("No se puede vincular un permiso que ya es hijo, o a si mismo. ");
            }
        }

        private bool SinLoop(Permiso padre, Permiso hijo)
        {
            if (padre.Id == hijo.Id)
            {
                return false;
            }
            bool sinLoop = true;
            foreach (Permiso permiso in ObtenerPadres(padre))
            {
                if (permiso.Id == hijo.Id)
                {
                    sinLoop = false;
                    break;
                }
                if (permiso is Familia)
                {
                    if (!SinLoop((Familia)permiso, hijo))
                    {
                        sinLoop = false;
                        break;
                    }
                }
            }
            return sinLoop;

        }

        public void DesvincularPadreHijo(Familia padre, Permiso hijo)
        {
            try
            {
                SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_PERMISO_HIJO", sqlParameters(padre, hijo));
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
        
        public override List<Permiso> GetAll()
        {
            List<Permiso> permisos = new List<Permiso>();
            DataTable dt = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TODOS_PERMISOS");
            foreach (DataRow row in dt.Rows)
            {
                permisos.Add(GetById(int.Parse(row["id"].ToString())));
            }
            return permisos;
        }

        public override Permiso GetById(int id)
        {
            DataTable dt = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_PERMISO_POR_ID", sqlParameters(id));
            if (dt.Rows.Count > 0)
            {
                if (int.Parse(dt.Rows[0]["esFamilia"].ToString()) == 1)
                {
                    Familia familia = new Familia();
                    familia.Id = id;
                    familia.Nombre = dt.Rows[0]["Nombre"].ToString();
                    DataTable dtHijos = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_PERMISOS_HIJOS", sqlParameters(id));
                    foreach (DataRow row in dtHijos.Rows)
                    {
                        Permiso permisoHijo = GetById(int.Parse(row["id"].ToString()));
                        familia.AgregarHijo(permisoHijo);   
                    }
                    return familia;
                }
                else {
                    Patente patente = new Patente();
                    patente.Id = id;
                    patente.Nombre = dt.Rows[0]["Nombre"].ToString();
                    patente.Tipo = EnumUtils.ParseEnum<TipoPermiso>(dt.Rows[0]["Tipo"].ToString());
                    return patente;
                }
            }
            return null;

        }

        public bool TienePadre(Permiso permiso) {
            //OBTENER_PERMISOS_PADRE
            DataTable dt = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_PERMISOS_PADRE", sqlParameters(permiso.Id));
            return dt.Rows.Count > 0;
        }

        public List<Permiso> ObtenerPadres(Permiso permiso) {
            DataTable dt = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_PERMISOS_PADRE", sqlParameters(permiso.Id));
            List<Permiso> permisos = new List<Permiso>();
            foreach (DataRow row in dt.Rows)
            {
                permisos.Add(GetById(int.Parse(row["FK_Id_Permiso_Padre"].ToString())));
            }
            return permisos;
        }

        public override int GetNextId()
        {
            //OBTENER_MAX_ID_PERMISO
            DataTable dt = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_MAX_ID_PERMISO");
            int id = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["id"] != DBNull.Value)
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

        public override void Update(Permiso entity)
        {
            //ACTUALIZAR_PERMISO
            SQLConnectionManager.getInstance().ExecuteProcedure("ACTUALIZAR_PERMISO", sqlParameters(entity)); 

        }

        public List<Permiso> GetByUser(Usuario usuario)
        {
            List<Permiso> permisos = new List<Permiso>();
            DataTable dt = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_PERMISOS_POR_ID_USUARIO", sqlParameters(usuario.Id));
            foreach (DataRow row in dt.Rows)
            {
                permisos.Add(GetById(int.Parse(row["id"].ToString())));
            }
            return permisos;
        }

        public void AgregarPermisoAUsuario(Usuario usuario, Permiso permiso)
        {
            try
            {
                SQLConnectionManager.getInstance().ExecuteProcedure("AGREGAR_PERMISO_A_USUARIO", sqlParameters(usuario, permiso));
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Violation of PRIMARY KEY constraint"))
                {
                    throw new Exception("El permiso ya esta asignado al usuario", ex);
                }
                else
                {
                    throw ex;
                }
            }
            
        }

        public void QuitarPermisoAUsuario(Usuario usuario, Permiso permiso)
        {
            SQLConnectionManager.getInstance().ExecuteProcedure("QUITAR_PERMISO_A_USUARIO", sqlParameters(usuario, permiso));
        }
        
    }
}
