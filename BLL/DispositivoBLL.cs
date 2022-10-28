using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using SERV;
using SERV.MultiIdioma;

namespace BLL
{
    public class DispositivoBLL : GenericBLL<Dispositivo>
    {
        public DispositivoBLL() 
        {
            dal = new DispositivoDAL();
            permiso = TipoPermiso.CRUDDispositivo;
        }

        public List<Dispositivo> getDispositivoByServicio(Servicio servicio) {
            if (!Session.GetSession().TienePermiso(this.permiso))
            {
                logger.Log("No tiene permiso para realizar esta accion", LogLevel.Warning, "Permiso Faltante: " + this.permiso.ToString(), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + this.permiso.ToString());
            }

            List<Dispositivo> dispositivos = ((DispositivoDAL)dal).getByServicio(servicio);
            logger.Log("Se obtuvieron los dispositivos del servicio " + servicio.Id, LogLevel.Debug, SERV.Serializacion.LogSerializer.Serialize(dispositivos), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
            return dispositivos;
        }

        public void AgregarDispositivoAServicio(Dispositivo dispositivo, Servicio servicio)
        {
            if (!Session.GetSession().TienePermiso(this.permiso))
            {
                logger.Log("No tiene permiso para realizar esta accion", LogLevel.Warning, "Permiso Faltante: " + this.permiso.ToString(), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + this.permiso.ToString());
            }
            
            ((DispositivoDAL)dal).AgregarDispositivoAServicio(dispositivo, servicio);
            logger.Log("Se agrego el dispositivo " + dispositivo.Id + " al servicio " + servicio.Id, LogLevel.Info, SERV.Serializacion.LogSerializer.Serialize(servicio), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public void QuitarDispositivoAServicio(Dispositivo dispositivo, Servicio servicio)
        {
            if (!Session.GetSession().TienePermiso(this.permiso))
            {
                logger.Log("No tiene permiso para realizar esta accion", LogLevel.Warning, "Permiso Faltante: " + this.permiso.ToString(), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + this.permiso.ToString());
            }
            
            
            ((DispositivoDAL)dal).QuitarDispositivoAServicio(dispositivo, servicio);
            logger.Log("Se quito el dispositivo " + dispositivo.Id + " del servicio " + servicio.Id, LogLevel.Info, SERV.Serializacion.LogSerializer.Serialize(servicio), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public List<Dispositivo> GetUnassigned() {
            if (!Session.GetSession().TienePermiso(this.permiso))
            {
                logger.Log("No tiene permiso para realizar esta accion", LogLevel.Warning, "Permiso Faltante: " + this.permiso.ToString(), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + this.permiso.ToString());
            }

            List<Dispositivo> dispositivos = ((DispositivoDAL)dal).GetUnassigned();
            logger.Log("Se obtuvieron los dispositivos sin asignar", LogLevel.Debug, SERV.Serializacion.LogSerializer.Serialize(dispositivos), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
            return dispositivos;
        }
    }
}
