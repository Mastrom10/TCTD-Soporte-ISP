using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using INTF;
using SERV.Composite;

namespace SERV 
{
    public class Usuario : ServiceEntity
    {

        public string Email { get; set; }
        public string Password { get; set; }

        public IEmpleado empleado { get; set; }

        private IList<IPermiso> _permisos;

        public IList<IPermiso> Permisos {
            //Singleton inline Por las dudas, aunque  _permisos deberia existir siempre
            get { return _permisos ?? (_permisos = new List<IPermiso>()); }
        }

        public Usuario()
        {
            _permisos = new List<IPermiso>();
        }


       


    }
}
