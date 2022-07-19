using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using SERV;

namespace BLL
{
    public abstract class GenericBLL<T> : ICrud<T> where T : IEntity
    {
        protected ICrud<T> dal;
        protected TipoPermiso permiso = TipoPermiso.CRUDAdmin;

        public virtual void Create(T entity)
        {
            if (!Session.GetSession().TienePermiso(permiso)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permiso.ToString());

            
            dal.Create(entity);
        }

        public virtual void Delete(T entity)
        {
            if (!Session.GetSession().TienePermiso(permiso)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permiso.ToString());

            dal.Delete(entity);
        }

        public virtual List<T> GetAll()
        {
            if (!Session.GetSession().TienePermiso(permiso)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permiso.ToString());

            return dal.GetAll();
        }

        public T GetByField(string field, string value)
        {
            if (!Session.GetSession().TienePermiso(permiso)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permiso.ToString());

            return dal.GetByField(field, value);
        }

        public virtual T GetById(int id)
        {
            if (!Session.GetSession().TienePermiso(permiso)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permiso.ToString());

            return dal.GetById(id);
        }

        public virtual int GetNextId()
        {
            if (!Session.GetSession().TienePermiso(permiso)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permiso.ToString());

            return dal.GetNextId();
        }

        public virtual void Update(T entity)
        {
            if (!Session.GetSession().TienePermiso(permiso)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permiso.ToString());

            dal.Update(entity);
        }
    }
}
