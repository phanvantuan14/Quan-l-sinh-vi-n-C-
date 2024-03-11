using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuanLiSinhVien.Model
{
    class MONHOC_DB
    {
        ConnectMySql db = new ConnectMySql();

        public bool themMH(string maMH, string tenMH, int soTC, int masv, int magv)
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `monhoc`(`MaMH`, `TenMH`,`SoTinChi`, `MaSV`, `MaGV`) " +
                "VALUES (@maMH, @tenMH, @sotinchi, @masv, @magv)", db.getConnection());

            command.Parameters.Add("@masv", MySqlDbType.Int32).Value = masv;
            command.Parameters.Add("@magv", MySqlDbType.Int32).Value = magv;
            command.Parameters.Add("@maMH", MySqlDbType.VarChar).Value = maMH;
            command.Parameters.Add("@tenMH", MySqlDbType.VarChar).Value = tenMH;
            command.Parameters.Add("@sotinchi", MySqlDbType.Int32).Value = soTC;

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

        public bool suaThongTinMH(string maMH, string tenMH, int soTC, int masv, int magv)
        {
            MySqlCommand command = new MySqlCommand
                ("UPDATE `monhoc` SET `TenMH`= @tenMH, `SoTinChi`= @soTC, " +
                "`MaSV`= @masv, `MaGV`= @magv WHERE `MaMH`= @maMH", 
                db.getConnection());
            command.Parameters.Add("@tenMH", MySqlDbType.VarChar).Value = tenMH;
            command.Parameters.Add("@maMH", MySqlDbType.VarChar).Value = maMH;
            command.Parameters.Add("@soTC", MySqlDbType.Int32).Value = soTC;
            command.Parameters.Add("@masv", MySqlDbType.Int32).Value = masv;
            command.Parameters.Add("@magv", MySqlDbType.Int32).Value = magv;

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

        public bool xoaMH(string maMH)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM monhoc WHERE MaMH = @maMH", db.getConnection());
            command.Parameters.Add("@maMH", MySqlDbType.VarChar).Value = maMH;

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

        public DataTable TimKiemMH(string tuKhoa)
        {
            DataTable ds = new DataTable();

            string query = "SELECT * FROM monhoc WHERE MaMH LIKE @tuKhoa or TenMH LIKE @tuKhoa";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.Add("@tuKhoa", MySqlDbType.VarChar).Value = "%" + tuKhoa + "%";

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);

            db.CloseConnection();

            return ds;
        }


        public bool KiemTraTonTaiMonHoc(string maMH)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM monhoc WHERE MaMH = @maMH", db.getConnection());
            command.Parameters.Add("@maMH", MySqlDbType.VarChar).Value = maMH;

            db.OpenConnection();
            int count = Convert.ToInt32(command.ExecuteScalar());
            db.CloseConnection();

            return count > 0; // Trả về true nếu có ít nhất một bản ghi phù hợp
        }

        public int LaySoLuongMH()
        {
            string query = "SELECT COUNT(*) FROM monhoc";
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

        public bool KiemTraTonTaiMaSV(int masv)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM `monhoc` WHERE `MaSV` = @masv", db.getConnection());
            command.Parameters.Add("@masv", MySqlDbType.VarChar).Value = masv;

            db.OpenConnection();
            int countSV = Convert.ToInt32(command.ExecuteScalar());
            db.CloseConnection();

            return countSV > 0;
        }

        public bool KiemTraTonTaiMaGV(int magv)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM `monhoc` WHERE `MaGV` = @magv", db.getConnection());
            command.Parameters.Add("@magv", MySqlDbType.VarChar).Value = magv;

            db.OpenConnection();
            int countGV = Convert.ToInt32(command.ExecuteScalar());
            db.CloseConnection();

            return countGV > 0;
        }

        public DataTable LayDanhSachMH()
        {
            DataTable ds = new DataTable();

            string query = "SELECT monhoc.*, sinhvien.HoTen AS TenSinhVien, giangvien.HoTen AS TenGiangVien " +
                    "FROM monhoc " +
                    "LEFT JOIN sinhvien ON monhoc.MaSV = sinhvien.MaSV " +
                    "LEFT JOIN giangvien ON monhoc.MaGV = giangvien.ID";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);
            db.CloseConnection();

            return ds;
        }

    }
}
