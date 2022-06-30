using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV.Composite
{
    public class Familia : Permiso

    {
        private IList<Permiso> hijos;

        public Familia(string nombre) :base(nombre)
        {
            this.hijos = new List<Permiso>();
        }
        public Familia()
        {
            this.hijos = new List<Permiso>();
        }

        public override void AgregarHijo(Permiso hijo)
        {
            if (!hijos.Contains(hijo))
            {
                hijos.Add(hijo);
            }
        }

        public override IList<Permiso> ObtenerHijos()
        {
            return hijos;
        }

        public override void QuitarHijo(Permiso hijo)
        {
            if (hijos.Contains(hijo))
            {
                hijos.Remove(hijo);
            }
        }
    }
}
