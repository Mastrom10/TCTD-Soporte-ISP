using System;
using System.Collections.Generic;
using DAL;
using BE;
using SERV;

namespace BLL
{
    public abstract class GenericBLL<T> : ICrud<T> where T : IEntity
    {
        protected ICrud<T> dal;
        protected TipoPermiso permiso = TipoPermiso.CRUDAdmin;
        protected BitacoraBLL logger = BitacoraBLL.GetInstance();
        

        public virtual void Create(T entity)
        {
            if (!Session.GetSession().TienePermiso(permiso)) {
                logger.Log(LogLevel.Warning, "No tiene permisos para crear " + typeof(T).Name, null, this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permiso.ToString());
            };

            try
            {
                dal.Create(entity);
                logger.Log(LogLevel.Info, "Se creo un nuevo registro de " + typeof(T).Name, SERV.Serializacion.LogSerializer.Serialize(entity), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, "Error al crear un nuevo registro de " + typeof(T).Name, SERV.Serializacion.LogSerializer.Serialize(entity), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw ex;
            }
        }

        public virtual void Delete(T entity)
        {
            if (!Session.GetSession().TienePermiso(permiso))
            {
                logger.Log(LogLevel.Warning, "No tiene permisos para eliminar " + typeof(T).Name, null, this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permiso.ToString());
            }
            
            try
            {
                dal.Delete(entity);
                logger.Log(LogLevel.Info, "Se elimino un registro de " + typeof(T).Name, SERV.Serializacion.LogSerializer.Serialize(entity), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, "Error al eliminar un registro de " + typeof(T).Name, SERV.Serializacion.LogSerializer.Serialize(entity), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw ex;
            }
        }

        public virtual List<T> GetAll()
        {
            if (!Session.GetSession().TienePermiso(permiso))
            {
                logger.Log(LogLevel.Warning, "No tiene permisos para listar " + typeof(T).Name, null, this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permiso.ToString());
            }
            
            try
            {
                List<T> lista = dal.GetAll();
                logger.Log(LogLevel.Debug, "Se obtuvieron todos los registros de " + typeof(T).Name, null, this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                return lista;
                }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, "Error al obtener todos los registros de " + typeof(T).Name, null, this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw ex;
            }
        }

        public T GetByField(string field, string value)
        {
            if (!Session.GetSession().TienePermiso(permiso))
            {
                logger.Log(LogLevel.Warning, "No tiene permisos para obtener " + typeof(T).Name, null, this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permiso.ToString());
            }
            try
            {
                T entity = dal.GetByField(field, value);
                logger.Log(LogLevel.Debug, "Se obtuvo un registro de " + typeof(T).Name +" con el criterio " + field + " = " + value , SERV.Serializacion.LogSerializer.Serialize(entity), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                return entity;
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, "Error al obtener un registro de " + typeof(T).Name + " por el campo " + field + " con el valor " + value, null, this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw ex;
            }
        }

        public virtual T GetById(int id)
        {
            if (!Session.GetSession().TienePermiso(permiso))
            {
                logger.Log(LogLevel.Warning, "No tiene permisos para obtener " + typeof(T).Name, null, this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permiso.ToString());
            }
            try
            {
                T entity = dal.GetById(id);
                if (entity == null)
                    throw new Exception("No se encontro el registro "+ typeof(T).Name +" con id " + id);
                logger.Log(LogLevel.Debug, "Se obtuvo un registro de " + typeof(T).Name + " por el id " + id, SERV.Serializacion.LogSerializer.Serialize(entity), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                return entity;
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, "Error al obtener un registro de " + typeof(T).Name + " por el id " + id, null, this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw ex;
            }
        }

        public virtual int GetNextId()
        {
            if (!Session.GetSession().TienePermiso(permiso))
            {
                logger.Log(LogLevel.Warning, "No tiene permisos para obtener el siguiente id de " + typeof(T).Name, null, this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permiso.ToString());
            }
            try
            {
                int nextID = dal.GetNextId();
                logger.Log(LogLevel.Debug, "Se obtuvo el siguiente id de " + typeof(T).Name + " con el valor " + nextID, null, this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                return nextID;
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, "Error al obtener el siguiente id de " + typeof(T).Name, null, this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw ex;
            }
        }

        public virtual void Update(T entity)
        {
            if (!Session.GetSession().TienePermiso(permiso))
            {
                logger.Log(LogLevel.Warning, "No tiene permisos para modificar " + typeof(T).Name, null, this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permiso.ToString());
            }

            
            try
            {
                dal.Update(entity);
                logger.Log(LogLevel.Info, "Se actualizo un registro de " + typeof(T).Name, SERV.Serializacion.LogSerializer.Serialize(entity), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, "Error al actualizar un registro de " + typeof(T).Name, SERV.Serializacion.LogSerializer.Serialize(entity), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw ex;
            }
        }
    }
}
