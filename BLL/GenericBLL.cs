using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace BLL
{
    public abstract class GenericBLL<T> : ICrud<T> where T : IEntity
    {
        protected ICrud<T> dal;

        public virtual void Create(T entity)
        {
            dal.Create(entity);
        }

        public virtual void Delete(T entity)
        {
            dal.Delete(entity);
        }

        public virtual List<T> GetAll()
        {
            return dal.GetAll();
        }

        public virtual T GetById(int id)
        {
            return dal.GetById(id);
        }

        public virtual int GetNextId()
        {
            return dal.GetNextId();
        }

        public virtual void Update(T entity)
        {
            dal.Update(entity);
        }
    }
}
