using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Empleado : Entity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumeroRepresentante { get; set; }
        public TipoEmpleado Rol { get; set; }
    }
}
