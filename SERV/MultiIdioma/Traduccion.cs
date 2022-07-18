using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV.MultiIdioma
{
    public class Traduccion : ServiceEntity
    {
        public Idioma idioma { get; set; }
        public Etiqueta etiqueta { get; set; }

        private string _traduccion;
        public string traduccion { get
            {
                if (_traduccion == null || _traduccion == "")
                {
                    return etiqueta.defaultText;
                }
                else {
                    return _traduccion;
                }
            } set { _traduccion = value; }  }
    }
}
