using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuanLiSinhVien.Model
{
    class DIEM_DB
    {
        ConnectMySql db = new ConnectMySql();

        public bool themDiem(string maSV, string maMH, float diem1, float diem2)
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `diem`(`MaSV`, `MaMH`, `Diem1`, `Diem2`) VALUES (@masv,@mamh,@diem1,@diem2)", db.getConnection());
            command.Parameters.Add("@masv", MySqlDbType.VarChar).Value = maSV;
            command.Parameters.Add("@mamh", MySqlDbType.VarChar).Value = maMH;
            command.Parameters.Add("@diem1", MySqlDbType.Float).Value = diem1;
            command.Parameters.Add("@diem2", MySqlDbType.Float).Value = diem2;

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

        public bool suaThongTinDiem(string maSV, string maMH, float diem1, float diem2)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `diem` SET `Diem1` = @diem1, `Diem2` = @diem2 WHERE `MaSV` = @maSV AND `MaMH` = @maMH", db.getConnection());
            command.Parameters.Add("@diem1", MySqlDbType.Float).Value = diem1;
            command.Parameters.Add("@diem2", MySqlDbType.Float).Value = diem2;
            command.Parameters.Add("@maMH", MySqlDbType.VarChar).Value = maMH;
            command.Parameters.Add("@maSV", MySqlDbType.VarChar).Value = maSV;

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

        public bool xoaDiem(int maSV)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM diem WHERE MaSV = @maSV", db.getConnection());
            command.Parameters.Add("@maSV", MySqlDbType.Int32).Value = maSV;

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

        public DataTable TimKiemDiem(string tuKhoa)
        {
            DataTable ds = new DataTable();

            string query = "SELECT * FROM diem WHERE MaSV LIKE @tuKhoa OR MaMH LIKE @tuKhoa";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.Add("@tuKhoa", MySqlDbType.VarChar).Value = "%" + tuKhoa + "%";

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);

            db.CloseConnection();

            return ds;
        }

        public bool KiemTraTonTaiMaSV(string masv)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM `sinhvien` WHERE `MaSV` = @masv", db.getConnection());
            command.Parameters.Add("@masv", MySqlDbType.VarChar).Value = masv;


            db.OpenConnection();
            int countSV = Convert.ToInt32(command.ExecuteScalar());
            db.CloseConnection();

            return countSV > 0;
        }
        public bool KiemTraTonTaiMaMH(string mamh)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM `monhoc` WHERE `MaMH` = @mamh", db.getConnection());
            command.Parameters.Add("@mamh", MySqlDbType.VarChar).Value = mamh;


            db.OpenConnection();
            int countMH = Convert.ToInt32(command.ExecuteScalar());
            db.CloseConnection();

            return countMH > 0;
        }

        public bool KiemTraTonTaiDiemSinhVien(string maSV, string maMH)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM diem WHERE MaSV = @maSV AND MaMH = @maMH", db.getConnection());
            command.Parameters.Add("@maSV", MySqlDbType.VarChar).Value = maSV;
            command.Parameters.Add("@maMH", MySqlDbType.VarChar).Value = maMH;

            db.OpenConnection();
            int count = Convert.ToInt32(command.ExecuteScalar());
            db.CloseConnection();

            return count > 0; // Trả về true nếu có ít nhất một bản ghi phù hợp
        }

        public int LaySoLuongSinhVienDat()
        {
            int soLuongSinhVienDat = 0;
            string query = "SELECT COUNT(*) FROM diem WHERE (Diem1 + Diem2) >= 5";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

            try
            {
                db.OpenConnection();
                soLuongSinhVienDat = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return soLuongSinhVienDat;
        }

        public int LaySoLuongSinhVienKhongDat()
        {
            int soLuongSinhVienKhongDat = 0;
            string query = "SELECT COUNT(*) FROM diem WHERE (Diem1 + Diem2) < 5";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

            try
            {
                db.OpenConnection();
                soLuongSinhVienKhongDat = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return soLuongSinhVienKhongDat;
        }

        public DataTable LayDanhSachDiem()
        {
            DataTable ds = new DataTable();

            string query = "SELECT diem.MaSV, sinhvien.HoTen,diem.MaMH,monhoc.TenMH,diem.Diem1, diem.Diem2 FROM sinhvien INNER JOIN diem ON sinhvien.MaSV = diem.MaSV INNER JOIN monhoc ON diem.MaMH = monhoc.MaMH";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

            try
            {
                db.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();
                ds.Load(reader);
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return ds;
        }
    }
}

