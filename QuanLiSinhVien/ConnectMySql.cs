using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien
{
    class ConnectMySql
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public ConnectMySql()
        {
            Initialize();
        }

        // Khởi tạo giá trị kết nối
        private void Initialize()
        {
            server = "localhost";
            database = "QLSinhVien";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                               database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
        // Mở kết nối với cơ sở dữ liệu
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Điều này sẽ hiển thị các lỗi kết nối MySQL, chẳng hạn như lỗi kết nối bị gián đoạn hoặc không thành công
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Đóng kết nối với cơ sở dữ liệu
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
