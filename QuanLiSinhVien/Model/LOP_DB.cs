using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuanLiSinhVien.Model
{
    class LOP_DB
    {


        ConnectMySql db = new ConnectMySql();

        public bool themLop(string malop, string makhoa, string tenlop)
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `lop`(`MaLop`,`MaKhoa`, `TenLop`) VALUES (@maLop,@maKhoa,@tenLop)", db.getConnection());

            command.Parameters.Add("@maLop", MySqlDbType.VarChar).Value = malop;
            command.Parameters.Add("@maKhoa", MySqlDbType.VarChar).Value = makhoa;
            command.Parameters.Add("@tenLop", MySqlDbType.VarChar).Value = tenlop;

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

        public bool suaThongTinLop(string malop, string makhoa, string tenlop)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `lop` SET `MaKhoa`= @maKhoa, `TenLop` = @tenLop WHERE `MaLop`= @maLop", db.getConnection());
            command.Parameters.Add("@maKhoa", MySqlDbType.VarChar).Value = makhoa;
            command.Parameters.Add("@tenLop", MySqlDbType.VarChar).Value = tenlop;
            command.Parameters.Add("@maLop", MySqlDbType.VarChar).Value = malop;

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

        public bool xoaLop(string malop)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM lop WHERE MaLop = @maLop", db.getConnection());
            command.Parameters.Add("@maLop", MySqlDbType.VarChar).Value = malop;

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

        public DataTable TimKiemLop(string tuKhoa)
        {
            DataTable ds = new DataTable();

            string query = "SELECT * FROM lop WHERE MaLop LIKE @tuKhoa or TenLop LIKE @tuKhoa";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.Add("@tuKhoa", MySqlDbType.VarChar).Value = "%" + tuKhoa + "%";

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);

            db.CloseConnection();

            return ds;
        }

        public bool KiemTraTonTaiMaLop(string maLop)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM lop WHERE MaLop = @maLop", db.getConnection());
            command.Parameters.Add("@maLop", MySqlDbType.VarChar).Value = maLop;

            db.OpenConnection();
            int count = Convert.ToInt32(command.ExecuteScalar());
            db.CloseConnection();

            return count > 0; // Trả về true nếu mã lớp đã tồn tại trong cơ sở dữ liệu
        }

        public int LaySoLuongLop()
        {
            string query = "SELECT COUNT(*) FROM lop";
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

        public DataTable LayDanhSachLop()
        {
            DataTable ds = new DataTable();

            string query = "SELECT lop.MaLop, lop.TenLop, lop.MaKhoa, khoa.TenKhoa FROM khoa INNER JOIN lop ON khoa.MaKhoa = lop.MaKhoa";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);
            db.CloseConnection();

            return ds;
        }

    }
}
