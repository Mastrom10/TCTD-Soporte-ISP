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


    }
}
