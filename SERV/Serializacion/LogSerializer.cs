using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SERV.Serializacion
{
    public static class LogSerializer
    {

        public static string Serialize(Object obj, bool recursivo = false, int profundidad = 0)
        {
            string respuesta = "";
            respuesta += recursivo ? "" : obj.GetType().ToString() + ":";
            //string spacer = recursivo ? "---" : "";
            string spacer = String.Concat(Enumerable.Repeat("---", profundidad));
            respuesta += obj.GetType().GetProperties()
                .Select(info =>
                {
                    try
                    {
                        if (info.PropertyType.IsPrimitive || info.PropertyType == typeof(string))
                        {
                            return (info.Name, Value: info.GetValue(obj, null) ?? "(null)");
                        }
                        else if (info.PropertyType.IsEnum)
                        {
                            return (info.Name, Value: info.GetValue(obj, null).ToString() ?? "(null)");
                        }
                        else
                        {
                            return (info.Name, Value: SerializeSubObject(info.GetValue(obj, null), profundidad) ?? "(null)");
                        }
                    }
                    catch (Exception e)
                    {
                        return (info.Name, Value: "ERROR: No se pudo serializar el objeto");
                    }
                })
                .Aggregate(
                new StringBuilder(),
                (sb, pair) => sb.Append($"\n{spacer} {pair.Name}: {pair.Value}"),
                sb => sb.ToString());


            return respuesta;
        }

        private static string SerializeSubObject(Object subObj, int profundidad)
        {
            if (profundidad > Config.loggerDepth)
            {
                return "Profundidad maxima alcanzada";
            }
            if (subObj == null)
            {
                return "(null)";
            }
           

            profundidad++;
            if (typeof(IEnumerable).IsAssignableFrom(subObj.GetType()))
            {
                string listaObjetos = "";
                foreach (var item in (IEnumerable)subObj)
                {
                    listaObjetos += Serialize(item, true, profundidad);
                }
                return listaObjetos;
            }
            else if (subObj.GetType().IsPrimitive || subObj.GetType() == typeof(string))
            {
                return subObj.ToString();
            }
            else if (subObj.GetType().IsEnum)
            {
                return subObj.ToString();
            }
            else if (subObj.GetType().IsArray)
            {
                return SerializeArray(subObj, profundidad);
            }
            else if (subObj.GetType().IsGenericType)
            {
                return SerializeGeneric(subObj, profundidad);
            }
            else if (subObj.GetType().IsClass)
            {
                return Serialize(subObj, true, profundidad);
            }
            else if (subObj.GetType() == DateTime.Now.GetType())
            {
                return ((DateTime)subObj).ToString();
            }
            else
            {
                return "Tipo no soportado";
            }

        }

        private static string SerializeArray(Object subObj, int profundidad)
        {
            string listaObjetos = "";
            foreach (var item in (Array)subObj)
            {
                listaObjetos += SerializeSubObject(item, profundidad);
            }
            return listaObjetos;
        }

        private static string SerializeGeneric(Object subObj, int profundidad)
        {
            string listaObjetos = "";
            foreach (var item in (IEnumerable)subObj)
            {
                listaObjetos += SerializeSubObject(item, profundidad);
            }
            return listaObjetos;
        }
        

    }
}
