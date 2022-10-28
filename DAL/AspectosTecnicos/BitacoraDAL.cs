using SERV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.AspectosTecnicos
{
    public class BitacoraDAL
    {
        public SqlParameter[] sqlParameters(Log log)
        {

            SqlParameter[] parametros = new SqlParameter[7];
            parametros[0] = new SqlParameter("@level", log.Level.ToString());
            parametros[0].DbType = System.Data.DbType.String;
            parametros[1] = new SqlParameter("@time", log.Time);
            parametros[1].DbType = System.Data.DbType.DateTime;
            parametros[2] = new SqlParameter("@user", log.User);
            parametros[2].DbType = System.Data.DbType.String;
            parametros[3] = new SqlParameter("@message", log.Message);
            parametros[3].DbType = System.Data.DbType.String;
            if (log.Details != null)
            {
                parametros[4] = new SqlParameter("@details", log.Details);
                parametros[4].DbType = System.Data.DbType.String;
            } else { 
                parametros[4] = new SqlParameter("@details", DBNull.Value); 
            }
            if (log.Class != null)
            {
                parametros[5] = new SqlParameter("@class", log.Class);
                parametros[5].DbType = System.Data.DbType.String;
            }
            else
            {
                parametros[5] = new SqlParameter("@class", DBNull.Value);
            }
            if (log.Method != null)
            {
                parametros[6] = new SqlParameter("@method", log.Method);
                parametros[6].DbType = System.Data.DbType.String;
            }
            else
            {
                parametros[6] = new SqlParameter("@method", DBNull.Value);
            }
            return parametros;
        }

        public SqlParameter[] sqlParameters(LogSearchingCriteria criteria) {
            /*
             public class LogSearchingCriteria
                  {
                      public Level Level { get; set; }
                      public DateTime TimeFrom { get; set; }
                      public DateTime TimeTo { get; set; }
                      public int Limit { get; set; }

                      public string User { get; set; }

                      public string Class { get; set; }

                      public string Method { get; set; }

                      public string Message { get; set; }
                      public string Details { get; set; }
                  }
            */
            SqlParameter[] parametros = new SqlParameter[9];
            if (criteria.Level != null)
            {
                parametros[0] = new SqlParameter("@level", criteria.Level.ToString());
                parametros[0].DbType = System.Data.DbType.String;
            }
            else
            {
                parametros[0] = new SqlParameter("@level", DBNull.Value);
            }
            if (criteria.TimeFrom != null && criteria.TimeFrom != DateTime.MinValue)
            {
                parametros[1] = new SqlParameter("@timeFrom", criteria.TimeFrom);
                parametros[1].DbType = System.Data.DbType.DateTime;
            }
            else
            {
                parametros[1] = new SqlParameter("@timeFrom", new DateTime(2000, 1, 1));
                parametros[1].DbType = System.Data.DbType.DateTime;
            }
            if (criteria.TimeTo != null && criteria.TimeTo != DateTime.MinValue)
            {
                parametros[2] = new SqlParameter("@timeTo", criteria.TimeTo);
                parametros[2].DbType = System.Data.DbType.DateTime;
            }
            else
            {
                parametros[2] = new SqlParameter("@timeTo", DateTime.Now);
                parametros[2].DbType = System.Data.DbType.DateTime;
            }
            if (criteria.Limit != 0)
            {
                parametros[3] = new SqlParameter("@limit", criteria.Limit);
                parametros[3].DbType = System.Data.DbType.Int32;
            }
            else
            {
                parametros[3] = new SqlParameter("@limit", DBNull.Value);
            }
            if (criteria.User != null)
            {
                parametros[4] = new SqlParameter("@user", criteria.User);
                parametros[4].DbType = System.Data.DbType.String;
            }
            else
            {
                parametros[4] = new SqlParameter("@user", DBNull.Value);
            }
            if (criteria.Class != null)
            {
                parametros[5] = new SqlParameter("@class", criteria.Class);
                parametros[5].DbType = System.Data.DbType.String;
            }
            else
            {
                parametros[5] = new SqlParameter("@class", DBNull.Value);
            }
            if (criteria.Method != null)
            {
                parametros[6] = new SqlParameter("@method", criteria.Method);
                parametros[6].DbType = System.Data.DbType.String;
            }
            else
            {
                parametros[6] = new SqlParameter("@method", DBNull.Value);
            }
            if (criteria.Message != null)
            {
                parametros[7] = new SqlParameter("@message", criteria.Message);
                parametros[7].DbType = System.Data.DbType.String;
            }
            else
            {
                parametros[7] = new SqlParameter("@message", DBNull.Value);
            }
            if (criteria.Details != null)
            {
                parametros[8] = new SqlParameter("@details", criteria.Details);
                parametros[8].DbType = System.Data.DbType.String;
            }
            else
            {
                parametros[8] = new SqlParameter("@details", DBNull.Value);
            }


            return parametros;
        }

        public void insertLog(Log log)
        {
            SQLConnectionManager.getInstance().ExecuteProcedure("SAVE_LOG", sqlParameters(log));
        }

        public List<Log> searchLogs(LogSearchingCriteria criteria)
        {
            List<Log> logs = new List<Log>();
            DataTable dt = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("GET_LOGS_BY_FIELDS_WITH_LIMIT", sqlParameters(criteria));
            foreach (DataRow row in dt.Rows)
            {
                logs.Add(mapToLog(row));
            }
            return logs;
        }
        public List<Log> getLastNLogs(int n)
        {
            if (n <= 0) {
                n = 100;
            }
            List<Log> logs = new List<Log>();
            DataTable dt = SQLConnectionManager.getInstance().ExecuteProcedureDataTable("GET_LOGS_BY_FIELDS_WITH_LIMIT", sqlParameters(new LogSearchingCriteria() { Limit = n }));
            foreach (DataRow row in dt.Rows)
            {
                logs.Add(mapToLog(row));
            }
            return logs;
        }


        private Log mapToLog(DataRow row)
        {
            //@id INT, @estadoTurno varchar(50), @fecha datetime, @franjaHoraria varchar(50)
            Log log = new Log();
            log.Id = (int)row["id"];
            log.Level = (LogLevel)Enum.Parse(typeof(LogLevel), row["level"].ToString());
            log.Time = (DateTime)row["time"];
            log.User = row["user"].ToString();
            log.Message = row["message"].ToString();
            log.Details = row["details"].ToString();
            log.Class = row["class"].ToString();
            log.Method = row["method"].ToString();
            return log;
        }


    }
}
