using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERV;

namespace DAL
{
    public class UsuarioDAL : GenericDAL<Usuario>
    {

        EmpleadoDAL empleadoDAL;
        public UsuarioDAL()
        {
            this.empleadoDAL = new EmpleadoDAL();
        }

        public override SqlParameter[] sqlParameters(Usuario usuario)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("@id", usuario.Id);
            parametros[0].DbType = System.Data.DbType.Int32;
            parametros[1] = new SqlParameter("@email", usuario.Email);
            parametros[1].DbType = System.Data.DbType.String;
            parametros[2] = new SqlParameter("@HashPassword", usuario.Password);
            parametros[2].DbType = System.Data.DbType.String;
            parametros[3] = new SqlParameter("@FK_id_Empleado", usuario.empleado.Id);
            parametros[3].DbType = System.Data.DbType.Int32;
            return parametros;
        }


        public override void Create(Usuario entity)
        {
            if (entity.Id == 0)
            {
                entity.Id = this.GetNextId();
            }
            SqlParameter[] parametros = sqlParameters(entity);
            SQLConnectionManager.getInstance().ExecuteProcedure("CREAR_USUARIO", parametros);
        }

        public override void Delete(Usuario entity)
        {
            //BORRAR_USUARIO
            SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_USUARIO", sqlParameters(entity));
        }

        public override List<Usuario> GetAll()
        {
            //OBTENER_TODOS_USUARIOS
            DataTable dt = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TODOS_USUARIOS");
            List<Usuario> usuarios = new List<Usuario>();
            foreach (DataRow row in dt.Rows)
            {
                Usuario usuario = new Usuario();
                usuario.Id = int.Parse(row["id"].ToString());
                usuario.Email = row["email"].ToString();
                usuario.Password = row["HashPassword"].ToString();
                usuario.empleado = this.empleadoDAL.GetById(int.Parse(row["FK_id_Empleado"].ToString()));
                usuarios.Add(usuario);
            }
            return usuarios;
        }


        
        public override Usuario GetByField(string field, string value)
        {
            switch (field)
            {
                case "id":
                    return this.GetById(int.Parse(value));
                case "email":
                    return this.GetByEmail(value);
                default:
                    return base.GetByField(field, value);
            }
           
        }

        //GetByEmail
        private Usuario GetByEmail(string email)
        {
            //OBTENER_USUARIO_POR_EMAIL
            SqlParameter paramemail = new SqlParameter("@email", email);
            paramemail.DbType = System.Data.DbType.String;
            SqlParameter[] parametros = new SqlParameter[] { paramemail };
            DataTable dt = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_USUARIO_POR_EMAIL", parametros);
            Usuario usuario = new Usuario();
            if (dt.Rows.Count > 0)
            {
                usuario.Id = int.Parse(dt.Rows[0]["id"].ToString());
                usuario.Email = dt.Rows[0]["email"].ToString();
                usuario.Password = dt.Rows[0]["HashPassword"].ToString();
                usuario.empleado = this.empleadoDAL.GetById(int.Parse(dt.Rows[0]["FK_id_Empleado"].ToString()));
                return usuario;
            }
            else {
                return null;
            }
           
        }

        public override Usuario GetById(int id)
        {
            //OBTENER_USUARIO_POR_ID
            SqlParameter paramId = new SqlParameter("@Id", id);
            paramId.DbType = DbType.Int32;
            SqlParameter[] parameters = new SqlParameter[] { paramId };
            DataTable dt = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_USUARIO_POR_ID", parameters);
            Usuario usuario = new Usuario();
            foreach (DataRow row in dt.Rows)
            {
                usuario.Id = int.Parse(row["id"].ToString());
                usuario.Email = row["email"].ToString();
                usuario.Password = row["HashPassword"].ToString();
                usuario.empleado = this.empleadoDAL.GetById(int.Parse(row["FK_id_Empleado"].ToString()));
            }
            return usuario;
            
        }

        public override int GetNextId()
        {
            //OBTENER_MAX_ID_USUARIO
            DataTable dt = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_MAX_ID_USUARIO");
            int id = 0;
            foreach (DataRow row in dt.Rows)
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

        public override void Update(Usuario entity)
        {
            //ACTUALIZAR_USUARIO
            SqlParameter[] parametros = sqlParameters(entity);
            SQLConnectionManager.getInstance().ExecuteProcedure("ACTUALIZAR_USUARIO", parametros);
            
        }

        
    }

    
}
