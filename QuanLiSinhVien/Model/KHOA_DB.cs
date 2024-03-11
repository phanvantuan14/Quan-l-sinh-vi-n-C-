using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuanLiSinhVien.Model
{
    class KHOA_DB
    {

        ConnectMySql db = new ConnectMySql();

        public bool themKhoa(string makhoa, string tenkhoa)
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `khoa`(`MaKhoa`, `TenKhoa`) VALUES (@maKhoa,@tenKhoa)", db.getConnection());

            command.Parameters.Add("@maKhoa", MySqlDbType.VarChar).Value = makhoa;
            command.Parameters.Add("@tenKhoa", MySqlDbType.VarChar).Value = tenkhoa;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.CloseConnection();
                return true;
            }
            else
            {
                db.CloseConnection();
                return false;
            }
        }

        public bool suaThongTinKhoa(string makhoa, string tenkhoa)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `khoa` SET `TenKhoa`= @tenKhoa WHERE `MaKhoa`= @maKhoa", db.getConnection());
            command.Parameters.Add("@tenKhoa", MySqlDbType.VarChar).Value = tenkhoa;
            command.Parameters.Add("@maKhoa", MySqlDbType.VarChar).Value = makhoa;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.CloseConnection();
                return true;
            }
            else
            {
                db.CloseConnection();
                return false;
            }
        }

        public bool xoaKhoa(string makhoa)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM khoa WHERE MaKhoa = @maKhoa", db.getConnection());
            command.Parameters.Add("@maKhoa", MySqlDbType.VarChar).Value = makhoa;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.CloseConnection();
                return true;
            }
            else
            {
                db.CloseConnection();
                return false;
            }
        }

        public DataTable TimKiemKhoa(string tuKhoa)
        {
            DataTable ds = new DataTable();

            string query = "SELECT * FROM khoa WHERE MaKhoa LIKE @tuKhoa or TenKhoa LIKE @tuKhoa";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.Add("@tuKhoa", MySqlDbType.VarChar).Value = "%" + tuKhoa + "%";

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);

            db.CloseConnection();

            return ds;
        }
        public bool KiemTraTonTaiKhoa(string maKhoa)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM khoa WHERE MaKhoa = @maKhoa", db.getConnection());
            command.Parameters.Add("@maKhoa", MySqlDbType.VarChar).Value = maKhoa;

            db.OpenConnection();
            int count = Convert.ToInt32(command.ExecuteScalar());
            db.CloseConnection();

            return count > 0; // Trả về true nếu có ít nhất một bản ghi phù hợp
        }

        public int LaySoLuongKhoa()
        {
            string query = "SELECT COUNT(*) FROM khoa";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

            int count = 0;

            try
            {
                db.OpenConnection();
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return count;
        }

        public DataTable LayDanhSachKhoa()
        {
            DataTable ds = new DataTable();

            string query = "SELECT * FROM khoa"; // Thay đổi câu lệnh SQL tùy theo cấu trúc của bảng hoatdong trong cơ sở dữ liệu của bạn
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);
            db.CloseConnection();

            return ds;
        }

    }
}

