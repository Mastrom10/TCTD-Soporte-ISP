using System;
using System.Collections.Generic;
using SERV.Composite;
using DAL;
using SERV;
using BE;

namespace BLL
{
    public class PermisoBLL : GenericBLL<Permiso>
    {
        PermisoDAL permisoDAL;
        public PermisoBLL()
        {
            permiso = TipoPermiso.CRUDPermiso;
            dal = new PermisoDAL();
            permisoDAL = (PermisoDAL)dal;
        }

        

        public void CrearFamilia(string Nombre)
        {
            TipoPermiso permisoEspecifico = TipoPermiso.PermisoCrearGrupos;
            if (!Session.GetSession().TienePermiso(permisoEspecifico))
            {
                logger.Log("El usuario no tiene permiso para crear familias", LogLevel.Warning, null, "PermisoBLL", "CrearFamilia");
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());
            }

            
            Familia familia = new Familia(Nombre);
            
            permisoDAL.Create(familia);
            logger.Log("Se creo la familia " + familia.Nombre, LogLevel.Info, null, "PermisoBLL", "CrearFamilia");
        }

        public void EliminarPermiso(Permiso permiso) {
            TipoPermiso permisoEspecifico = TipoPermiso.PermisoEliminarPermisos;
            if (!Session.GetSession().TienePermiso(permisoEspecifico))
            {
                logger.Log("El usuario  no tiene permiso para eliminar permisos", LogLevel.Warning, null, "PermisoBLL", "EliminarPermiso");
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());
            }

            if (permiso is Familia)
            {
                permisoDAL.Delete(permiso);
                logger.Log("Se elimino la familia " + permiso.Nombre, LogLevel.Info, null, "PermisoBLL", "EliminarPermiso");
            }
            else {
                logger.Log("No se puede eliminar el permiso " + permiso.Nombre + " porque no es una familia", LogLevel.Debug, null, "PermisoBLL", "EliminarPermiso");
                throw new Exception("No está permitido eliminar permisos Base");
            }
            
        }

        public bool TienePadre(Permiso permiso)
        {
            return permisoDAL.TienePadre(permiso);
        }

        public List<Permiso> getPermisosPorUsuario(Usuario usuario)
        {
            TipoPermiso permisoEspecifico = TipoPermiso.PermisoObtenerPermisosPorUsuario;
            if (!Session.GetSession().TienePermiso(permisoEspecifico))
            {
                logger.Log("El usuario  no tiene permiso para obtener permisos por usuario", LogLevel.Warning, null, "PermisoBLL", "getPermisosPorUsuario");
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());
            }

            List<Permiso> permisos = permisoDAL.GetByUser(usuario);
            if (usuario.Equals(Session.GetSession().usuario)) {
                Session.GetSession().usuario.Permisos = permisos;
            }
            logger.Log("Se obtuvieron los permisos del usuario " + usuario.Email, LogLevel.Debug, null, "PermisoBLL", "getPermisosPorUsuario");
            return permisos;
        }

        public void AgregarPermisoAUsuario(Usuario user, Permiso permiso)
        {
            TipoPermiso permisoEspecifico = TipoPermiso.PermisoAgregarPermisoAUsuario;
            if (!Session.GetSession().TienePermiso(permisoEspecifico))
            {
                logger.Log("El usuario  no tiene permiso para agregar permisos a usuarios", LogLevel.Warning, null, "PermisoBLL", "AgregarPermisoAUsuario");
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());
            }

            
            permisoDAL.AgregarPermisoAUsuario(user, permiso);
            logger.Log("Se agrego el permiso " + permiso.Nombre + " al usuario " + user.Email, LogLevel.Info, null, "PermisoBLL", "AgregarPermisoAUsuario");
            if (user == Session.GetSession().usuario) {
                Session.GetSession().usuario.Permisos = permisoDAL.GetByUser(user);
            }
        }

        //QuitarPermisoAUsuario
        public void QuitarPermisoAUsuario(Usuario user, Permiso permiso)
        {
            TipoPermiso permisoEspecifico = TipoPermiso.QuitarPermisoAUsuario;
            if (!Session.GetSession().TienePermiso(permisoEspecifico))
            {
                logger.Log("El usuario  no tiene permiso para quitar permisos a usuarios", LogLevel.Warning, null, "PermisoBLL", "QuitarPermisoAUsuario");
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());
            }
            
            permisoDAL.QuitarPermisoAUsuario(user, permiso);
            logger.Log("Se quito el permiso " + permiso.Nombre + " al usuario " + user.Email, LogLevel.Info, null, "PermisoBLL", "QuitarPermisoAUsuario");
            if (user == Session.GetSession().usuario)
            {
                Session.GetSession().usuario.Permisos = permisoDAL.GetByUser(user);
            }
        }

        public void VincularPadreHijo(Permiso padre, Permiso hijo)
        {
            TipoPermiso permisoEspecifico = TipoPermiso.PermisoVincularPadreHijo;
            if (!Session.GetSession().TienePermiso(permisoEspecifico))
            {
                logger.Log("El usuario  no tiene permiso para vincular padres e hijos", LogLevel.Warning, null, "PermisoBLL", "VincularPadreHijo");
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());
            }

            
            if (padre is Familia)
            {
                permisoDAL.VincularPadreHijo((Familia)padre, hijo);
                logger.Log("Se vinculo el permiso " + hijo.Nombre + " con el permiso " + padre.Nombre, LogLevel.Info, null, "PermisoBLL", "VincularPadreHijo");
            }
            else {
                logger.Log("No se puede vincular el permiso " + hijo.Nombre + " con el permiso " + padre.Nombre + " porque el permiso " + padre.Nombre + " no es una familia", LogLevel.Debug, null, "PermisoBLL", "VincularPadreHijo");
                throw new Exception("El padre debe ser una familia");
            }
            
        }

        //DesvincularPadreHijo
        public void DesvincularPadreHijo(Permiso padre, Permiso hijo)
        {
            TipoPermiso permisoEspecifico = TipoPermiso.PermisoDesvincularPadreHijo;
            if (!Session.GetSession().TienePermiso(permisoEspecifico))
            {
                logger.Log("El usuario  no tiene permiso para desvincular padres e hijos", LogLevel.Warning, null, "PermisoBLL", "DesvincularPadreHijo");
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());
            }
            
            if (padre is Familia)
            {
                permisoDAL.DesvincularPadreHijo((Familia)padre, hijo);
                logger.Log("Se desvinculo el permiso " + hijo.Nombre + " con el permiso " + padre.Nombre, LogLevel.Info, null, "PermisoBLL", "DesvincularPadreHijo");
            }
            else
            {
                logger.Log("No se puede desvincular el permiso " + hijo.Nombre + " con el permiso " + padre.Nombre + " porque el permiso " + padre.Nombre + " no es una familia", LogLevel.Debug, null, "PermisoBLL", "DesvincularPadreHijo");
                throw new Exception("El padre debe ser una familia");
            }
        }

       

    }
}
