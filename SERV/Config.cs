using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV
{

    /* Se opta por crear una clase estatica para guardar todas las configuraciones, por su simplicidad.
     * a futuro las configuraciones deberán  ser recolectadas a travez del ConfigurationManager del framework 
     * y las configuraciones persistirlas en un archivo Json.
     */
    
    public static class Config
    {
        public static byte[] EncriptionKey = { 1, 5, 4, 8, 3, 6, 5, 9 };
        public static byte[] EncriptionVector = { 9, 7, 6, 4, 5, 8, 1, 2 };
        public static int loggerDepth = 3;
        public static LogLevel logLevel = LogLevel.Debug;
        
       
       

    }
}
