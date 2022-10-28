using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using BE;
using System.Collections;


namespace SERV
{
    public class Log : ServiceEntity {
        public LogLevel Level { get; set; }
        public DateTime Time { get; set; }
        public string User { get; set; }

        public string Class { get; set; }
        
        public string Method { get; set; }

        public string Message { get; set; }
        public string Details { get; set; }
    }

    public class LogSearchingCriteria
    {
        public LogLevel Level { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public int Limit { get; set; }

        public string User { get; set; }

        public string Class { get; set; }

        public string Method { get; set; }

        public string Message { get; set; }
        public string Details { get; set; }
    }



    public enum LogLevel { 
        Debug, Info, Warning, Error, Fatal
    }

}
