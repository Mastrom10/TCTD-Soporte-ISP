using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using SERV.MultiIdioma;
using SERV;
using BE;

namespace BLL
{
    public class IdiomaBLL : GenericBLL<Idioma>
    {
        public IdiomaBLL()
        {
            permiso = TipoPermiso.CRUDIdioma;
            dal = new IdiomaDAL();
        }

        public void SeleccionarIdioma(Idioma idioma)
        {
            TipoPermiso permisoEspecifico = TipoPermiso.IdiomaSeleccionarIdioma;
            if (!Session.GetSession().TienePermiso(permisoEspecifico)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());


            if (Session.GetSession().IsLogged())
            {
                ((IdiomaDAL)dal).SetIdiomaToUser(idioma, Session.GetSession().usuario);
                Session.CambiarIdioma(idioma);
            }
            else {
                throw new Exception("El usuario no se encuentra logueado");
            }
        }
    }
}
