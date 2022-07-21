using System.Collections.Generic;

namespace BE
{
    public class Servicio : Entity
    {
        public EstadoServicio estado { get; set; }

        public ServicePlan servicePlan { get; set; }
        
        public List<Dispositivo> dispositivos { get; set; }
    }
}