using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using SERV;
using DAL;

namespace BLL
{
    public class DireccionBLL : GenericBLL<Direccion>
    {
        public DireccionBLL()
        {
            dal = new DireccionDAL();
            permiso = TipoPermiso.CRUDDireccion; 
        }

        public Direccion getByCliente(Cliente cliente) {

            if (!Session.GetSession().TienePermiso(this.permiso))
            {
                logger.Log("No tiene permiso para realizar esta accion", LogLevel.Warning, "Permiso Faltante: "+ this.permiso.ToString(), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + this.permiso.ToString());
            }

            
            Direccion direccion = ((DireccionDAL)dal).GetByCliente(cliente);
            logger.Log("Se obtuvo un registro de direccion por el cliente " + cliente.Id.ToString(), LogLevel.Debug, SERV.Serializacion.LogSerializer.Serialize(direccion), "DireccionBLL", "getByCliente");
            return direccion;
        }

        
    }
}
