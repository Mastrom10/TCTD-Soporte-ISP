using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class InteraccionTicket : Entity
    {

        public string accion { get; set; }
        public string motivo { get; set; }
        public string observacion { get; set; }
        public DateTime fecha { get; set; }
        public Empleado empleado { get; set; }

        public int idTicket { get; set; }

    }
}