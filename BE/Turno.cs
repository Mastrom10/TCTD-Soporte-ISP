using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Turno : Entity
    {
         
        public EstadoTurno estadoTurno { get; set; }

        public DateTime fecha { get; set; }
        
        public FranjaHoraria franjaHoraria { get; set; }

        public override string ToString()
        {
            return fecha.ToString("d") + " - " + franjaHoraria.ToString();
        }
    }
}
