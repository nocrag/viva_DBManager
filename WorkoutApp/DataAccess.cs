using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp
{
    public class DataAccess
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["GymAppConnString"].ConnectionString;
        public static DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
        public static int SendData(string sql)
        {
            int rowsAffected = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            return rowsAffected;
        }

        public static string SQLCleaner(string sql)
        {

            while (sql.Contains("  "))
                sql = sql.Replace("  ", " ");

            return sql.Replace(Environment.NewLine, "");
        }

        public static string SQLFix(string sql)
        {
            return sql.Replace("'", "''");
        }
    }
}
