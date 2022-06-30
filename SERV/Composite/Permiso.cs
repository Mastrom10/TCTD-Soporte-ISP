using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV.Composite
{
    public  abstract class Permiso : ServiceEntity
    {
        public string Nombre { get; set; }

        public Permiso(string nombre)
        {
            Nombre = nombre;
        }
        public Permiso()
        {
        }

        public abstract IList<Permiso> ObtenerHijos();
        public abstract void AgregarHijo(Permiso hijo);
        public abstract void QuitarHijo(Permiso hijo);
        

    }
}
