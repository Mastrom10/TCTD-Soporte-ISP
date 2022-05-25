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

        public void Create(T entity)
        {
            dal.Create(entity);
        }

        public void Delete(T entity)
        {
            dal.Delete(entity);
        }

        public List<T> GetAll()
        {
            return dal.GetAll();
        }

        public T GetById(int id)
        {
            return dal.GetById(id);
        }

        public int GetNextId()
        {
            return dal.GetNextId();
        }

        public void Update(T entity)
        {
            dal.Update(entity);
        }
    }
}
