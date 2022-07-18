using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using SERV.MultiIdioma;
using SERV;

namespace BLL
{
    public class IdiomaBLL : GenericBLL<Idioma>
    {
        public IdiomaBLL()
        {
            dal = new IdiomaDAL();
        }

        public void SeleccionarIdioma(Idioma idioma)
        {
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
