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
    public class NodoRedDAL : GenericDAL<NodoRed>
    {
        public override void Create(NodoRed entity)
        {
            //CREAR_NODORED
            if (entity.Id == 0)
            {
                entity.Id = GetNextId();
            }
            SQLConnectionManager.getInstance().ExecuteProcedure("CREAR_NODORED", sqlParameters(entity));
        }

        public override void Delete(NodoRed entity)
        {
            //BORRAR_
            SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_NODORED", sqlParameters(entity));
        }

        public override List<NodoRed> GetAll()
        {
            //OBTENER_TODOS_
            List<NodoRed> nodos = new List<NodoRed>();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TODOS_NODOSRED");
            foreach (DataRow row in datatable.Rows)
            {
                nodos.Add(new NodoRed()
                {
                    Id = int.Parse(row["id"].ToString()),
                    nombre = row["nombre"].ToString(),
                    estado = (EstadoNodo)Enum.Parse(typeof(EstadoNodo), row["estado"].ToString())
                });
            }
            return nodos;  
        }

        public override NodoRed GetById(int id)
        {
            //OBTENER_POR_ID_
            NodoRed nodo = new NodoRed();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_POR_ID_NODOSRED", sqlParameters(id));
            if (datatable.Rows.Count > 0)
            {
                nodo.Id = int.Parse(datatable.Rows[0]["id"].ToString());
                nodo.nombre = datatable.Rows[0]["nombre"].ToString();
                nodo.estado = (EstadoNodo)Enum.Parse(typeof(EstadoNodo), datatable.Rows[0]["estado"].ToString());
                return nodo;
            } else
            {
                return null;
            }
        }

        public override int GetNextId()
        {
            //OBTENER_MAX_ID_
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_MAX_ID_NODOSRED");
            if (datatable.Rows.Count > 0)
            {
                return int.Parse(datatable.Rows[0]["id"].ToString()) + 1;
            }
            else
            {
                return 1;
            }
        }

        public override SqlParameter[] sqlParameters(NodoRed entity)
        {
            //public string nombre;
            //public EstadoNodo estado;
            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = new SqlParameter("@nombre", entity.nombre);
            parametros[0].DbType = System.Data.DbType.String;
            parametros[1] = new SqlParameter("@estado", entity.estado.ToString());
            parametros[1].DbType = System.Data.DbType.String;
            parametros[2] = new SqlParameter("@id", entity.Id);
            parametros[2].DbType = System.Data.DbType.Int32;
            return parametros;
        }

        public SqlParameter[] sqlParameters(int id)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@id", id);
            parametros[0].DbType = System.Data.DbType.Int32;
            return parametros;
        }

        public override void Update(NodoRed entity)
        {
            //ACTUALIZAR_
            SQLConnectionManager.getInstance().ExecuteProcedure("ACTUALIZAR_NODORED", sqlParameters(entity));
            
        }
    }
}
