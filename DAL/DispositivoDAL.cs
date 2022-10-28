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
    public class DispositivoDAL : GenericDAL<Dispositivo>
    {
       

        public override void Create(Dispositivo entity)
        {
            //CREAR_DISPOSITIVO
            if (entity.Id == 0)
            {
                entity.Id = GetNextId();
            }
            SQLConnectionManager.getInstance().ExecuteProcedure("CREAR_DISPOSITIVO", sqlParameters(entity));
        }

        public override void Delete(Dispositivo entity)
        {
            //BORRAR_DISPOSITIVO
            SQLConnectionManager.getInstance().ExecuteProcedure("BORRAR_DISPOSITIVO", sqlParameters(entity));
        }

        public override List<Dispositivo> GetAll()
        {
            //OBTENER_TODOS_DISPOSITIVO
            List<Dispositivo> dispositivos = new List<Dispositivo>();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_TODOS_DISPOSITIVO");
            foreach (DataRow row in datatable.Rows)
            {
                dispositivos.Add(mapRowtoDispositivo(row));
            }
            return dispositivos;
        }

        public override Dispositivo GetById(int id)
        {
            //OBTENER_POR_ID_DISPOSITIVO
            
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_POR_ID_DISPOSITIVO", sqlParameters(id));
            if (datatable.Rows.Count > 0)
            {
                return mapRowtoDispositivo(datatable.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public override int GetNextId()
        {
            //OBTENER_MAX_ID_DISPOSITIVO 
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_MAX_ID_DISPOSITIVO");
            int id = 0;
            try
            {
                if (datatable.Rows.Count > 0)
                {
                    id = int.Parse(datatable.Rows[0]["id"].ToString());
                }
            }
            catch (Exception)
            { }
            return id + 1;
        }


        public override SqlParameter[] sqlParameters(Dispositivo entity)
        {
            //@id INT, @tipo VARCHAR(50) = NULL, @macAdress VARCHAR(50), @nroserie VARCHAR(50) = NULL
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@id", entity.Id);
            parameters[0].DbType = System.Data.DbType.Int32;
            parameters[1] = new SqlParameter("@tipo", entity.tipo);
            parameters[1].DbType = System.Data.DbType.String;
            parameters[2] = new SqlParameter("@macAdress", entity.macAdress);
            parameters[2].DbType = System.Data.DbType.String;
            parameters[3] = new SqlParameter("@nroserie", entity.nroserie);
            parameters[3].DbType = System.Data.DbType.String;
            return parameters;
        }


        public override void Update(Dispositivo entity)
        {
            //ACTUALIZAR_DISPOSITIVO
            SQLConnectionManager.getInstance().ExecuteProcedure("ACTUALIZAR_DISPOSITIVO", sqlParameters(entity));
        }

         

        public SqlParameter[] sqlParameters(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", id);
            parameters[0].DbType = System.Data.DbType.Int32;
            return parameters;

        }

        public SqlParameter[] sqlParameters(int idDispositivo, int idServicio)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@idDispositivo", idDispositivo);
            parameters[0].DbType = System.Data.DbType.Int32;
            parameters[1] = new SqlParameter("@idServicio", idServicio);
            parameters[1].DbType = System.Data.DbType.Int32;
            return parameters;
        }

        
        public List<Dispositivo> getByServicio(Servicio servicio)
        {
            //OBTENER_DISPOSITIVOS_POR_SERVICIO
            List<Dispositivo> dispositivos = new List<Dispositivo>();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_DISPOSITIVOS_POR_SERVICIO", sqlParameters(servicio.Id));
            foreach (DataRow row in datatable.Rows)
            {
                dispositivos.Add(mapRowtoDispositivo(row));
            }
            return dispositivos;
        }


        Dispositivo mapRowtoDispositivo(DataRow row) {
            Dispositivo dispositivo = new Dispositivo();
            dispositivo.Id = int.Parse(row["id"].ToString());
            dispositivo.tipo = row["tipo"].ToString();
            dispositivo.macAdress = row["macAdress"].ToString();
            dispositivo.nroserie = row["nroserie"].ToString();
            return dispositivo;
        }

        public void AgregarDispositivoAServicio(Dispositivo dispositivo, Servicio servicio)
        {
            //AGREGAR_DISPOSITIVO_A_SERVICIO
            SQLConnectionManager.getInstance().ExecuteProcedure("AGREGAR_DISPOSITIVO_A_SERVICIO", sqlParameters(dispositivo.Id, servicio.Id));
        }

        public void QuitarDispositivoAServicio(Dispositivo dispositivo, Servicio servicio)
        {
            //QUITAR_DISPOSITIVO_A_SERVICIO
            SQLConnectionManager.getInstance().ExecuteProcedure("QUITAR_DISPOSITIVO_A_SERVICIO", sqlParameters(dispositivo.Id, servicio.Id));
        }

        public List<Dispositivo> GetUnassigned()
        {
            //OBTENER_UNASSIGNED_DISPOSITIVO
            List<Dispositivo> dispositivos = new List<Dispositivo>();
            DataTable datatable = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("OBTENER_UNASSIGNED_DISPOSITIVO");
            foreach (DataRow row in datatable.Rows)
            {
                dispositivos.Add(mapRowtoDispositivo(row));
            }
            return dispositivos;
        }
    }
    
}
