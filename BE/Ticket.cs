using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Ticket : Entity, ICloneable
    {
            
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public EstadoTicket estado { get; set; }
        public PrioridadTicket prioridad { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaUltimaModificacion { get; set; }
        public DateTime fechaCierre { get; set; }
        public Cliente cliente { get; set; }
        public Empleado empleado { get; set; }
        public List<InteraccionTicket> interacciones { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "Ticket " + this.Id + ": " + this.fechaCreacion.ToString("dd/MM/yyyy HH:mm")  + " - " +this.estado.ToString() + " - " + this.titulo;
        }

    }
}
