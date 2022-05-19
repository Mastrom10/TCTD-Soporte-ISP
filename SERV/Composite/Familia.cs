using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV.Composite
{
    internal class Familia : ServiceEntity, IPermiso

    {
        public string Nombre { get; set; }

        private IList<IPermiso> hijos;

        public Familia()
        {
            this.hijos = new List<IPermiso>();
        }

        public void AgregarHijo(IPermiso hijo)
        {
            if (!hijos.Contains(hijo))
            {
                hijos.Add(hijo);
            }
        }

        public IList<IPermiso> ObtenerHijos()
        {
            return hijos;
        }

        public void QuitarHijo(IPermiso hijo)
        {
            if (hijos.Contains(hijo))
            {
                hijos.Remove(hijo);
            }
        }
    }
}
