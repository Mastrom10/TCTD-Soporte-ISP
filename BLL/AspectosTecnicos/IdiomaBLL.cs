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
            if (!Session.GetSession().TienePermiso(permisoEspecifico))
            {
                logger.Log("No tiene permiso para " + permisoEspecifico, LogLevel.Warning, null, "IdiomaBLL","SeleccionarIdioma");
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());
            }

            if (Session.GetSession().IsLogged())
            {
                ((IdiomaDAL)dal).SetIdiomaToUser(idioma, Session.GetSession().usuario);
                Session.CambiarIdioma(idioma);
                logger.Log("Idioma seleccionado: " + idioma.Nombre, LogLevel.Debug, null, "IdiomaBLL", "SeleccionarIdioma");
            }
            else {
                logger.Log("No se pudo seleccionar el idioma: " + idioma.Nombre + " porque no hay un usuario logueado", LogLevel.Warning, null, "IdiomaBLL", "SeleccionarIdioma");
                throw new Exception("El usuario no se encuentra logueado");
            }
        }
    }
}
