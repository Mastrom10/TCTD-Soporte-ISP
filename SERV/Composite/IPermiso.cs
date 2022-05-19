using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV.Composite
{
    public  interface IPermiso
    {
        string Nombre { get; set; }
        IList<IPermiso> ObtenerHijos();
        void AgregarHijo(IPermiso hijo);
        void QuitarHijo(IPermiso hijo);
        

    }
}
