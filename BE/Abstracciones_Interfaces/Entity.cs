
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }

        //new con id opcional o 0
        public Entity()
        {
            Id = 0;
        }
        public Entity(int id)
        {
            Id = id;
        }
    }
}
