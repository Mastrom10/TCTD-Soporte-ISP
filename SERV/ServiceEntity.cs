using INTF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV
{
    public abstract class ServiceEntity : IEntity
    {
        public int Id { get; set; }
    }
}
