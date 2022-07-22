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
            return ((DispositivoDAL)dal).getByServicio(servicio);
        }

        public void AgregarDispositivoAServicio(Dispositivo dispositivo, Servicio servicio)
        {
            ((DispositivoDAL)dal).AgregarDispositivoAServicio(dispositivo, servicio);
        }

        public void QuitarDispositivoAServicio(Dispositivo dispositivo, Servicio servicio)
        {
            ((DispositivoDAL)dal).QuitarDispositivoAServicio(dispositivo, servicio);
        }

        public List<Dispositivo> GetUnassigned() {
            return ((DispositivoDAL)dal).GetUnassigned();
        }
    }
}
