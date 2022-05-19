using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV.Composite
{
    internal class Patente : ServiceEntity, IPermiso
    {

        public Enum Tipo { get; set; }
        
        public string Nombre { get; set; }

        public void AgregarHijo(IPermiso hijo)
        {    
        }

        public IList<IPermiso> ObtenerHijos()
        {
            return new List<IPermiso>();
        }
        public void QuitarHijo(IPermiso hijo)
        {
        }
    }
}
