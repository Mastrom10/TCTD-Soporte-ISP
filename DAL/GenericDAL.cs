using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public abstract class GenericDAL<T> : ICrud<T> where T : IEntity
    {

        public abstract SqlParameter[] sqlParameters(T entity);
        public abstract void Create(T entity);
        
        public abstract void Delete(T entity);

        public abstract List<T> GetAll();
        
        public abstract T GetById(int id);
        
        public abstract int GetNextId();
        
        public abstract void Update(T entity);
        
    }
}
