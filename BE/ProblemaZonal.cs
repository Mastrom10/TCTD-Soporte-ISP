using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    internal class ProblemaZonal : Entity
    {
        public string titulo { get; set; }
        public string descipcion { get; set; }
        public DateTime fechaReportado { get; set; }

        public DateTime fechaEstimadaResolucion { get; set; }

        public List<NodoRed> nodosAfectados { get; set; }
    }
}
