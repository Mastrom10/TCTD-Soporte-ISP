using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV.MultiIdioma
{
    public static class IdiomaUtils
    {

        public static List<Traduccion> traducciones;
        

        public static string Tag(string tag)
        {
            string traduccion = tag;
            try
            {
                if (traducciones != null)
                {
                    traduccion = traducciones.Find(x => x.etiqueta.Nombre == tag).traduccion;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontraron/ Faltan traducciones para la etiqueta " + tag);
            }
            return traduccion;
        }

    }
}
