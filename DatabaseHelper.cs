using Microsoft.Data.SqlClient;

namespace Giao_diện_demo.Database
{
    public class DatabaseHelper
    {
        private readonly IConfiguration _config;

        public DatabaseHelper(IConfiguration config)
        {
            _config = config;
        }

        public string TestConnection()
        {
            try
            {
                string? connStr =
                    _config.GetConnectionString("DefaultConnection");

                using SqlConnection conn =
                    new SqlConnection(connStr);

                conn.Open();

                return "Kết nối SQL Server thành công!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}