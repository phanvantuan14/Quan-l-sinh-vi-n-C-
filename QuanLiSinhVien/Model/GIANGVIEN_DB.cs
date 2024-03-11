using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuanLiSinhVien.Model
{
    class GIANGVIEN_DB
    {
        ConnectMySql db = new ConnectMySql();

        public bool themGiangVien(string hoten, DateTime ngaysinh, string gioitinh, string SDT, string diachi, string makhoa, string mamh)
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `giangvien`(`HoTen`, `NgaySinh`, `GioiTinh`, `SDT`, `DiaChi`, `MaKhoa`, `MaMH`) VALUES (@hoten,@ngaysinh,@gioitinh,@SDT,@diachi,@makhoa, @mamh)", db.getConnection());
            //@hoten,@ngaysinh,@ngaysinh,@SDT, @diachi,@makhoa
            command.Parameters.Add("@hoten", MySqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@ngaysinh", MySqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@gioitinh", MySqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@SDT", MySqlDbType.VarChar).Value = SDT;
            command.Parameters.Add("@diachi", MySqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@makhoa", MySqlDbType.VarChar).Value = makhoa;
            command.Parameters.Add("@mamh", MySqlDbType.VarChar).Value = mamh;

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

        public bool suaThongTinGiangVien(string hoten, DateTime ngaysinh, string gioitinh, string SDT, string diachi, string makhoa,string mamh, int magv)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `giangvien` SET `HoTen` = @hoten, `NgaySinh` = @ngaysinh, `GioiTinh` = @gioitinh, `SDT` = @SDT, `DiaChi` = @diachi, `MaKhoa` = @makhoa, `MaMH` = @mamh WHERE `ID` = @magv", db.getConnection());
            command.Parameters.Add("@hoten", MySqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@ngaysinh", MySqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@gioitinh", MySqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@SDT", MySqlDbType.VarChar).Value = SDT;
            command.Parameters.Add("@diachi", MySqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@makhoa", MySqlDbType.VarChar).Value = makhoa;
            command.Parameters.Add("@mamh", MySqlDbType.VarChar).Value = mamh;
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

        public bool xoaGiangVien(int maSV)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM giangvien WHERE ID = @magv", db.getConnection());
            command.Parameters.Add("@magv", MySqlDbType.Int32).Value = maSV;

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

        public DataTable TimKiemGiangVien(string tuKhoa)
        {
            DataTable ds = new DataTable();

            string query = "SELECT * FROM giangvien WHERE HoTen LIKE @tuKhoa OR SDT LIKE @tuKhoa OR DiaChi LIKE @tuKhoa OR MaKhoa LIKE @tuKhoa";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.Add("@tuKhoa", MySqlDbType.VarChar).Value = "%" + tuKhoa + "%";

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);

            db.CloseConnection();

            return ds;
        }
        public bool KiemTraTonTaiMaKhoa(string makhoa)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM `khoa` WHERE `MaKhoa` = @makhoa", db.getConnection());
            command.Parameters.Add("@makhoa", MySqlDbType.VarChar).Value = makhoa;


            db.OpenConnection();
            int countKhoa = Convert.ToInt32(command.ExecuteScalar());
            db.CloseConnection();

            return countKhoa > 0;
        }
        public bool KiemTraTonTaiMaMH(string mamh)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM `monhoc` WHERE `MaMH` = @mamh", db.getConnection());
            command.Parameters.Add("@mamh", MySqlDbType.VarChar).Value =mamh;


            db.OpenConnection();
            int countMH = Convert.ToInt32(command.ExecuteScalar());
            db.CloseConnection();

            return countMH > 0;
        }

        public bool KiemTraTonTaiGiangVien(string hote, DateTime ngaysinh, string gioitinh, string SDT, string diachi, string makhoa, string mamh)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM giangvien WHERE HoTen = @hote AND NgaySinh = @ngaysinh AND GioiTinh = @gioitinh AND SDT = @sdt AND DiaChi = @diachi AND MaKhoa = @makhoa AND MaMH = @mamh", db.getConnection());
            command.Parameters.Add("@hote", MySqlDbType.VarChar).Value = hote;
            command.Parameters.Add("@ngaysinh", MySqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@gioitinh", MySqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@sdt", MySqlDbType.VarChar).Value = SDT;
            command.Parameters.Add("@diachi", MySqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@makhoa", MySqlDbType.VarChar).Value = makhoa;
            command.Parameters.Add("@mamh", MySqlDbType.VarChar).Value = mamh;

            db.OpenConnection();
            int count = Convert.ToInt32(command.ExecuteScalar());
            db.CloseConnection();

            return count > 0; // Trả về true nếu có ít nhất một bản ghi phù hợp
        }

        public int LaySoLuongGiangVien()
        {
            string query = "SELECT COUNT(*) FROM giangvien";
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

        public DataTable LayDanhSachGiangVien()
        {
            DataTable ds = new DataTable();

            string query = "SELECT giangvien.ID, giangvien.HoTen,giangvien.NgaySinh, giangvien.GioiTinh,giangvien.SDT, giangvien.DiaChi, " +
                "giangvien.MaKhoa,khoa.TenKhoa, giangvien.MaMH, monhoc.TenMH  FROM giangvien " +
                "INNER JOIN khoa ON giangvien.MaKhoa = khoa.MaKhoa " +
                "INNER JOIN monhoc ON giangvien.MaMH = monhoc.MaMH";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);
            db.CloseConnection();

            return ds;
        }
    }
}
