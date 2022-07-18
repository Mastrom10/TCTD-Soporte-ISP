using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV.MultiIdioma
{
    public class Etiqueta : ServiceEntity
    {
        public string Nombre { get; set; }
        public string defaultText { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
