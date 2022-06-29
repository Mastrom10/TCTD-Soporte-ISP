using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV.Composite
{
    public class Patente : Permiso
    {

        public Enum Tipo { get; set; }
        
        public override void AgregarHijo(Permiso hijo)
        {    
        }

        public override IList<Permiso> ObtenerHijos()
        {
            return new List<Permiso>();
        }
        public override void QuitarHijo(Permiso hijo)
        {
        }
    }
}
