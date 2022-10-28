using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SERV.Serializacion
{
    internal class JsonSerializator<T> : AbstractSerializator<T>
    {
        public override T Deserializar(Stream str)
        {
            return JsonSerializer.Deserialize<T>(str);

        }

        public override object Serializar(object obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}
