using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SERV.Serializacion
{
    internal class XmlSerializator<T> : AbstractSerializator<T>
    {
        public override T Deserializar(Stream str)
        {
            var serializer = new XmlSerializer(typeof(T));
            TextReader reader = new StreamReader(str);
            T o = (T)serializer.Deserialize(reader);
            reader.Close();
            return o;

        }

        public override object Serializar(object obj)
        {
            FileStream fs = FileStreamManager.Instance.CreateFile("tmp.xml");
            StreamWriter writer = new StreamWriter(fs);
            XmlSerializer ser = new XmlSerializer(typeof(T));
            ser.Serialize(writer, obj);
            writer.Close();
            fs.Close();
            return fs.Name;

        }
    }
}
