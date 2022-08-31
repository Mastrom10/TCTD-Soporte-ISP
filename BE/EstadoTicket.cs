using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum EstadoTicket
    {
        Abierto,
        Cerrado,
        Cancelado,
        EnProceso,
        DerivadoBackoffice,
        DerivadoTecnico,
    }
}
