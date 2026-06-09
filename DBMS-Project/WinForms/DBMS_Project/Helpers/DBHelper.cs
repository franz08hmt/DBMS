using System;
using System.Data;
using System.Data.SqlClient;

namespace DBMS_Project
{
    public static class DBHelper
    {
        private static string connectionString =
            "Server=G15\\SQLEXPRESS;Database=QuanLyThuVien;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static SqlConnection GetConnection(string database)
        {
            string cs = "Server=G15\\SQLEXPRESS;" +
                        "Database=" + database + ";" +
                        "Trusted_Connection=True;" +
                        "TrustServerCertificate=True;";
            return new SqlConnection(cs);
        }

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}