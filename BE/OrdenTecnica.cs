using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class OrdenTecnica : Entity
    {
        
        public Turno turno { get; set; }

        public TipoOrdenTecnica tipoOrdenTecnica { get; set; }

        public string notas { get; set; }
        
        public Ticket ticket { get; set; } 
        
    }
}
