using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    internal class SQLConnectionManager
    {
        SqlConnection connection;
        SqlConnectionStringBuilder connectionStringBuilder;

        public SQLConnectionManager()
        {
            connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = ".\\SQLEXPRESS";
            connectionStringBuilder.InitialCatalog = "SoporteISP";
            connectionStringBuilder.IntegratedSecurity = true;
        }
        
        //open connection to database
        void Open()
        {
            if (connection == null) {
                connection = new SqlConnection(connectionStringBuilder.ConnectionString);
            }
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //close connection to database
        void Close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Dispose();
            connection = null;
            GC.Collect(); 
        }
        
        //execute query with Parameters
        public int ExecuteQuery(string query, SqlParameter[] parameters)
        {
            Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddRange(parameters);
            int result = command.ExecuteNonQuery();
            Close();
            return result;
        }

        //Execute query with no parameters
        public int ExecuteQuery(string query)
        {
            Open();
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();
            Close();
            return result;
        }

        //Execute procedure with parameters
        public int ExecuteProcedure(string procedure, SqlParameter[] parameters)
        {
            Open();
            SqlCommand command = new SqlCommand(procedure, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters);
            int result = command.ExecuteNonQuery();
            Close();
            return result;
        }

        //Execute procedure with no parameters
        public int ExecuteProcedure(string procedure)
        {
            Open();
            SqlCommand command = new SqlCommand(procedure, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            int result = command.ExecuteNonQuery();
            Close();
            return result;
        }

        //Execute query and return DataTable
        public DataTable ExecuteQueryDataTable(string query)
        {
            Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Close();
            return dataTable;
        }

        //Execute query with Parameters and return DataTable
        public DataTable ExecuteQueryDataTable(string query, SqlParameter[] parameters)
        {
            Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Close();
            return dataTable;
        }

        //Execute procedure and return DataTable
        public DataTable ExecuteProcedureDataTable(string procedure)
        {
            Open();
            SqlCommand command = new SqlCommand(procedure, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Close();
            return dataTable;
        }

        //Execute procedure with parameters and return DataTable
        public DataTable ExecuteProcedureDataTable(string procedure, SqlParameter[] parameters)
        {
            Open();
            SqlCommand command = new SqlCommand(procedure, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Close();
            return dataTable;
        }

        //Read .SQL file, Execute query and return result
        public int ExecuteSQLFile(string fileName)
        {
            string query = System.IO.File.ReadAllText(fileName);
            return ExecuteQuery(query);
        }
        








    }
}
