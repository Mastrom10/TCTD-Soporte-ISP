using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente : Entity
    {
        public int nro_Cliente { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaDeNacimiento { get; set; }
        public string email { get; set; }
        public string telefonoPrincipal { get; set; }
        public string telefonoSecundario { get; set; }
        public Direccion direccion { get; set; }
        public Servicio servicio { get; set; }
    }
}
