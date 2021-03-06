using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using SERV.Composite;
using SERV.MultiIdioma;

namespace SERV 
{
    public class Usuario : ServiceEntity
    {

        public string Email { get; set; }
        public string Password { get; set; }

        public Idioma idioma {
            get;set;
        } 

        public Empleado empleado { get; set; }

        private List<Permiso> _permisos;

        public List<Permiso> Permisos {
            //Singleton inline Por las dudas, aunque  _permisos deberia existir siempre
            get { return _permisos ?? (_permisos = new List<Permiso>());}
            set { _permisos = value; }
        }

        public Usuario()
        {
            _permisos = new List<Permiso>();
        }

        public override bool Equals(object obj)
        {
            if (obj is Usuario)
            {
                return ((Usuario)obj).Email.Equals(Email);
            }
            else {
                return false;
            }
        }





    }
}
