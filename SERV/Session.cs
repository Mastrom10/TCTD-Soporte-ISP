using SERV.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERV.MultiIdioma;

namespace SERV
{
    public class Session
    {

        public Usuario usuario { get; set; }

        private static Session _session;
        private static object _lock = new object();
        private Session(){}

        public static Session GetSession()
        {
            lock (_lock)
            {
                if (_session == null)
                {
                    _session = new Session();
                }
            }
            return _session;
        }
        
        public void Login(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public void Logout()
        {
            this.usuario = null;
        }

        public bool IsLogged()
        {
            return this.usuario != null;
        }

        public bool TienePermiso (Enum tipoPermiso)
        {
            if (this.usuario == null)
            {
                return false;
            }

            bool tienePermiso = false;

            foreach (Permiso permiso in this.usuario.Permisos)
            {
                if (permiso is Patente && ((Patente)permiso).Tipo.Equals(tipoPermiso))
                {
                    tienePermiso = true;
                    break;
                } else
                {
                    tienePermiso = TienePermisoRecursivo(permiso, tipoPermiso, tienePermiso);
                }
            }
            return tienePermiso;
        }

        private bool TienePermisoRecursivo(Permiso permiso, Enum tipoPermiso, bool tienePermiso)
        {
            foreach (Permiso permisoHijo in permiso.ObtenerHijos())
            {
                if (permisoHijo is Patente && ((Patente)permisoHijo).Tipo.Equals(tipoPermiso)) {
                    tienePermiso = true;
                    break;
                }
                else
                {
                    tienePermiso = TienePermisoRecursivo(permisoHijo, tipoPermiso, tienePermiso);
                }
            }
            return tienePermiso;
        }


        static List<IIdiomaObserver> _observers = new List<IIdiomaObserver>();

        public static void SuscribirObservador(IIdiomaObserver o)
        {
            _observers.Add(o);
        }
        public static void DesuscribirObservador(IIdiomaObserver o)
        {
            _observers.Remove(o);
        }

        private static void Notificar(Idioma idioma)
        {
            foreach (IIdiomaObserver o in _observers)
            {
                o.ActualizarIdioma(idioma);
            }
        }

        public static void CambiarIdioma(Idioma idioma)
        {
            if (GetSession().IsLogged())
            {
                GetSession().usuario.idioma = idioma;
                
                Notificar(idioma);
            }
        }


    }
}
