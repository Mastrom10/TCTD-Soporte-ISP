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
    public class ServicioBLL : GenericBLL<Servicio>
    {
        public ServicioBLL()
        {
            dal = new ServicioDAL();
            permiso = TipoPermiso.CRUDServicio;
        }

        public Servicio GetByCliente(Cliente cliente) {
            if (!Session.GetSession().TienePermiso(this.permiso))
            {
                logger.Log("No tiene permiso para realizar esta accion", LogLevel.Warning, "Permiso Faltante: " + this.permiso.ToString(), this.GetType().ToString());
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + this.permiso.ToString());
            }
            Servicio servicio = ((ServicioDAL)dal).GetByCliente(cliente);
            logger.Log("Se obtuvo el servicio del cliente " + cliente.Id, LogLevel.Debug, SERV.Serializacion.LogSerializer.Serialize(servicio), this.GetType().ToString());
            return servicio;
        }
    }
}
