using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using SERV.MultiIdioma;

namespace BLL
{
    public class TraduccionBLL : GenericBLL<Traduccion>
    {
        TraduccionDAL tDAL;
        public TraduccionBLL() {
            tDAL = new TraduccionDAL();
            dal = tDAL;
        }

        public List<Traduccion> GetAllByIdioma(Idioma idioma)
        {
            return tDAL.GetAllByIdioma(idioma);
        }

        public void UpdateMany(List<Traduccion> traducciones)
        {
            foreach (Traduccion t in traducciones)
            {
                if (t.traduccion != null && t.traduccion.Length > 0)
                {
                    tDAL.Update(t);
                }
            }
        }
    }
}
