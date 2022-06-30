using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERV.Composite;
using DAL;
using BE;
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

        public void CrearPatente(string Nombre, TipoPermiso tipoPermiso)
        {
            Patente patente = new Patente(Nombre, tipoPermiso);
            permisoDAL.Create(patente);
        }

        public void CrearFamilia(string Nombre)
        {
            Familia familia = new Familia(Nombre);
            
            permisoDAL.Create(familia);
        }

        public void EliminarPermiso(Permiso permiso) {
            permisoDAL.Delete(permiso);
        }

        public bool TienePadre(Permiso permiso)
        {
            return permisoDAL.TienePadre(permiso);
        }

        public List<Permiso> getPermisosPorUsuario(Usuario usuario)
        {
            return permisoDAL.GetByUser(usuario);
        }

        public void AgregarPermisoAUsuario(Usuario user, Permiso permiso)
        {
            permisoDAL.AgregarPermisoAUsuario(user, permiso);
        }

        //QuitarPermisoAUsuario
        public void QuitarPermisoAUsuario(Usuario user, Permiso permiso)
        {
            permisoDAL.QuitarPermisoAUsuario(user, permiso);
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
