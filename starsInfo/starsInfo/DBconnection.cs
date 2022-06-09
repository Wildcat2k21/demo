using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace starsInfo
{
    class DBconnection
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;
        private SqlConnection connection = new SqlConnection(connectionString);

        public void OpenConnection() {
            if (connection.State == ConnectionState.Closed) {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeNonQuery(string sql) {
            int result;
            SqlCommand command = new SqlCommand(sql, connection);
            this.OpenConnection();
            command.ExecuteNonQuery();
            this.CloseConnection();
        }

        public DataTable ExecuteSqlCommand(string sql) {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(sql, connection);
            this.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            this.CloseConnection();

            return table;
        }

        public SqlConnection GetConnection() {
            return connection;
        }
    }
}
