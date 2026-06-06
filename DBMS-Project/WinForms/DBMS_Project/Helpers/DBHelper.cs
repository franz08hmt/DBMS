using System;
using System.Data;
using System.Data.SqlClient;

namespace DBMS_Project
{
    public static class DBHelper
    {
        // ⚠️ Sửa "TEN_SERVER" thành tên SQL Server instance trên máy bạn
        // Thường là: localhost, .\SQLEXPRESS, hoặc TenMay\SQLEXPRESS
        private static string connectionString =
            "Server=G15\\SQLEXPRESS;Database=QuanLyThuVien;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
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