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
            if (!Session.GetSession().TienePermiso(permisoEspecifico)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());

            Familia familia = new Familia(Nombre);
            
            permisoDAL.Create(familia);
        }

        public void EliminarPermiso(Permiso permiso) {
            TipoPermiso permisoEspecifico = TipoPermiso.PermisoEliminarPermisos;
            if (!Session.GetSession().TienePermiso(permisoEspecifico)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());


            if (permiso is Familia)
            {
                permisoDAL.Delete(permiso);
            }
            else {
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
            if (!Session.GetSession().TienePermiso(permisoEspecifico)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());


            List<Permiso> permisos = permisoDAL.GetByUser(usuario);
            if (usuario.Equals(Session.GetSession().usuario)) {
                Session.GetSession().usuario.Permisos = permisos;
            }
            return permisos;
        }

        public void AgregarPermisoAUsuario(Usuario user, Permiso permiso)
        {
            TipoPermiso permisoEspecifico = TipoPermiso.PermisoAgregarPermisoAUsuario;
            if (!Session.GetSession().TienePermiso(permisoEspecifico)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());


            
            permisoDAL.AgregarPermisoAUsuario(user, permiso);
            if (user == Session.GetSession().usuario) {
                Session.GetSession().usuario.Permisos = permisoDAL.GetByUser(user);
            }
        }

        //QuitarPermisoAUsuario
        public void QuitarPermisoAUsuario(Usuario user, Permiso permiso)
        {
            TipoPermiso permisoEspecifico = TipoPermiso.QuitarPermisoAUsuario;
            if (!Session.GetSession().TienePermiso(permisoEspecifico)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());

            
            permisoDAL.QuitarPermisoAUsuario(user, permiso);
            if (user == Session.GetSession().usuario)
            {
                Session.GetSession().usuario.Permisos = permisoDAL.GetByUser(user);
            }
        }

        public void VincularPadreHijo(Permiso padre, Permiso hijo)
        {
            TipoPermiso permisoEspecifico = TipoPermiso.PermisoVincularPadreHijo;
            if (!Session.GetSession().TienePermiso(permisoEspecifico)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());


            
            if (padre is Familia)
            {
                permisoDAL.VincularPadreHijo((Familia)padre, hijo);
            }
            else {
                throw new Exception("El padre debe ser una familia");
            }
            
        }

        //DesvincularPadreHijo
        public void DesvincularPadreHijo(Permiso padre, Permiso hijo)
        {
            TipoPermiso permisoEspecifico = TipoPermiso.PermisoDesvincularPadreHijo;
            if (!Session.GetSession().TienePermiso(permisoEspecifico)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());

            
            if (padre is Familia)
            {
                permisoDAL.DesvincularPadreHijo((Familia)padre, hijo);
            }
            else
            {
                throw new Exception("El padre debe ser una familia");
            }
        }

       

    }
}
