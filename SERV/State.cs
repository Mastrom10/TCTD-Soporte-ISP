using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace SERV
{
    public  class State<T> where T : IEntity
    {
        public int idCambio { get; set; }
        public Usuario usuario { get; set; }
        public TipoCambio tipoCambio { get; set; }
        public DateTime fecha { get; set; }
        public T entity { get; set; }

        public string ToStringList { get {
                return fecha.ToString("d") + " id:" + idCambio.ToString() +
                    " | " + tipoCambio.ToString() +
                    " | " + usuario.Email;
            }
        }
    }


    

    public enum TipoCambio { 
        Create, 
        Update, 
        Delete,
        Restore,
        Other
        
    }
}
