using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using SERV.MultiIdioma;

namespace BLL
{
    public class IdiomaBLL : GenericBLL<Idioma>
    {
        public IdiomaBLL()
        {
            dal = new IdiomaDAL();
        }
    }
}
