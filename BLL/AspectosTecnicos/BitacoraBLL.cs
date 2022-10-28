using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERV;
using DAL.AspectosTecnicos;
using System.Runtime.CompilerServices;

namespace BLL
{
    public class BitacoraBLL
    {

        //Singleton
        private static BitacoraBLL instance;
        public static BitacoraBLL GetInstance()
        {
            if (instance == null)
            {
                instance = new BitacoraBLL();
                instance.bitacoraDAL = new BitacoraDAL();
            }
            return instance;
        }

        BitacoraDAL bitacoraDAL;


        public void Log(string message, LogLevel level = LogLevel.Info, string details = null, string Class = null, [CallerMemberName] string method = null)
        {
            if (level < Config.logLevel)
                return;

            Log logRegister = new Log()
            {
                Level = level,
                Time = DateTime.Now,
                User = Session.GetSession().IsLogged() ? Session.GetSession().usuario.Email : "anonimo",
                Class = Class,
                Method = method,
                Message = message,
                Details = details
            };
            bitacoraDAL.insertLog(logRegister);
        }
        public void Log(LogLevel level, string message, string details = null, string Class = null, [CallerMemberName] string method = null)
        {
            if (level < Config.logLevel)
                return;
            
            Log logRegister = new Log()
            {
                Level = level,
                Time = DateTime.Now,
                User = Session.GetSession().IsLogged() ? Session.GetSession().usuario.Email : "anonimo",
                Class = Class,
                Method = method,
                Message = message,
                Details = details
            };
            bitacoraDAL.insertLog(logRegister);
        }


        public List<Log> searchLogs(LogSearchingCriteria criteria)
        {
            return bitacoraDAL.searchLogs(criteria);
        }

        public List<Log> getLastNLogs(int n)
        {
            return bitacoraDAL.getLastNLogs(n);
        }

    }
}
