using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV.Serializacion
{
    public abstract class AbstractSerializator<T>
    {
        public abstract T Deserializar(Stream str);

        public abstract object Serializar(object obj);
        
    }
}
