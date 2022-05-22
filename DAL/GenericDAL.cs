using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public abstract class GenericDAL<T> : ICrud<T> where T : IEntity
    {
        
        private List<T> _DatosEnMemoria;

        public GenericDAL()
        {
            _DatosEnMemoria = new List<T>();
        }

        
        public virtual void Create(T entity)
        {
            if (entity.Id == 0)
            {
                entity.Id = GetNextId();
            }
            _DatosEnMemoria.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _DatosEnMemoria.Remove(entity);
        }

        public virtual List<T> GetAll()
        {
            return _DatosEnMemoria;
        }

        public virtual T GetById(int id)
        {
            return _DatosEnMemoria.FirstOrDefault(x => x.Id == id);
        }

        public virtual int GetNextId()
        {
            return _DatosEnMemoria.Count == 0 ? 1 : _DatosEnMemoria.Max(x => x.Id) + 1;
        }

        public virtual void Update(T entity)
        {
            var index = _DatosEnMemoria.FindIndex(x => x.Id == entity.Id);
            _DatosEnMemoria[index] = entity;
        }
    }
}
