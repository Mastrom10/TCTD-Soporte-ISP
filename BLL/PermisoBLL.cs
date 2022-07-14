using System;
using System.Collections.Generic;
using SERV.Composite;
using DAL;
using SERV;

namespace BLL
{
    public class PermisoBLL : GenericBLL<Permiso>
    {
        PermisoDAL permisoDAL;
        public PermisoBLL()
        {
            dal = new PermisoDAL();
            permisoDAL = (PermisoDAL)dal;
        }

        

        public void CrearFamilia(string Nombre)
        {
            Familia familia = new Familia(Nombre);
            
            permisoDAL.Create(familia);
        }

        public void EliminarPermiso(Permiso permiso) {
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
            List<Permiso> permisos = permisoDAL.GetByUser(usuario);
            if (usuario.Equals(Session.GetSession().usuario)) {
                Session.GetSession().usuario.Permisos = permisos;
            }
            return permisos;
        }

        public void AgregarPermisoAUsuario(Usuario user, Permiso permiso)
        {
            permisoDAL.AgregarPermisoAUsuario(user, permiso);
            if (user == Session.GetSession().usuario) {
                Session.GetSession().usuario.Permisos = permisoDAL.GetByUser(user);
            }
        }

        //QuitarPermisoAUsuario
        public void QuitarPermisoAUsuario(Usuario user, Permiso permiso)
        {
            permisoDAL.QuitarPermisoAUsuario(user, permiso);
            if (user == Session.GetSession().usuario)
            {
                Session.GetSession().usuario.Permisos = permisoDAL.GetByUser(user);
            }
        }

        public void VincularPadreHijo(Permiso padre, Permiso hijo)
        {
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
