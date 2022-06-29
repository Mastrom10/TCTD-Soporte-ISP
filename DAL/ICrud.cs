using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface ICrud<T> where T : IEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);

        T GetByField(string field, string value);
        List<T> GetAll();
        int GetNextId();
    }
}
