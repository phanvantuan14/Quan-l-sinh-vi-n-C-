using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuanLiSinhVien
{
    class SINHVIEN_DB
    {
        ConnectMySql db = new ConnectMySql();

        public bool themSinhVien(string hoten, DateTime ngaysinh, string gioitinh, string SDT, string diachi, string malop)
        {
           
            MySqlCommand command = new MySqlCommand("INSERT INTO `sinhvien`(`HoTen`, `NgaySinh`, `GioiTinh`, `SDT`, `DiaChi`, `MaLop`) VALUES (@hoten,@ngaysinh,@gioitinh,@SDT,@diachi,@malop)", db.getConnection());
            //@hoten,@ngaysinh,@ngaysinh,@SDT, @diachi,@malop
            command.Parameters.Add("@hoten", MySqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@ngaysinh", MySqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@gioitinh", MySqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@SDT", MySqlDbType.VarChar).Value = SDT;
            command.Parameters.Add("@diachi", MySqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@malop", MySqlDbType.VarChar).Value = malop;

            db.OpenConnection();
            if(command.ExecuteNonQuery() == 1)
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

        public bool suaThongTinSinhVien(string hoten, DateTime ngaysinh, string gioitinh, string SDT, string diachi, string malop, int masv)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `sinhvien` SET `HoTen` = @hoten, `NgaySinh` = @ngaysinh, `GioiTinh` = @gioitinh, `SDT` = @SDT, `DiaChi` = @diachi, `MaLop` = @malop WHERE `MaSV` = @masv", db.getConnection());
            command.Parameters.Add("@hoten", MySqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@ngaysinh", MySqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@gioitinh", MySqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@SDT", MySqlDbType.VarChar).Value = SDT;
            command.Parameters.Add("@diachi", MySqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@malop", MySqlDbType.VarChar).Value = malop;
            command.Parameters.Add("@masv", MySqlDbType.Int32).Value = masv;

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

        public bool xoaSinhVien(int maSV)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM sinhvien WHERE MaSV = @maSV", db.getConnection());
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

        public DataTable TimKiemSinhVien(string tuKhoa)
        {
            DataTable ds = new DataTable();

            string query = "SELECT * FROM sinhvien WHERE HoTen LIKE @tuKhoa OR SDT LIKE @tuKhoa OR DiaChi LIKE @tuKhoa OR MaLop LIKE @tuKhoa";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.Add("@tuKhoa", MySqlDbType.VarChar).Value = "%" + tuKhoa + "%";

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);

            db.CloseConnection();

            return ds;
        }

        public bool KiemTraTonTaiMaLop(string malop)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM `lop` WHERE `MaLop` = @malop", db.getConnection());
            command.Parameters.Add("@malop", MySqlDbType.VarChar).Value = malop;

            db.OpenConnection();
            int count = Convert.ToInt32(command.ExecuteScalar());
            db.CloseConnection();

            return count > 0; // Trả về true nếu có ít nhất một bản ghi có mã lớp trùng khớp, ngược lại trả về false
        }

        public bool KiemTraTonTaiSinhVien(string hote, DateTime ngaysinh, string gioitinh, string SDT, string diachi, string malop)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM sinhvien WHERE HoTen = @hote AND NgaySinh = @ngaysinh AND GioiTinh = @gioitinh AND SDT = @sdt AND DiaChi = @diachi AND MaLop = @malop", db.getConnection());
            command.Parameters.Add("@hote", MySqlDbType.VarChar).Value = hote;
            command.Parameters.Add("@ngaysinh", MySqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@gioitinh", MySqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@sdt", MySqlDbType.VarChar).Value = SDT;
            command.Parameters.Add("@diachi", MySqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@malop", MySqlDbType.VarChar).Value = malop;

            db.OpenConnection();
            int count = Convert.ToInt32(command.ExecuteScalar());
            db.CloseConnection();

            return count > 0; // Trả về true nếu có ít nhất một bản ghi phù hợp
        }

        public int LaySoLuongSinhVien()
        {
            string query = "SELECT COUNT(*) FROM sinhvien";
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

        public DataTable LayDanhSachSinhVien()
        {
            DataTable ds = new DataTable();

            string query = "SELECT sinhvien.MaSV, sinhvien.HoTen, sinhvien.NgaySinh, sinhvien.GioiTinh, sinhvien.SDT, sinhvien.DiaChi, sinhvien.MaLop, lop.TenLop " +
                           "FROM lop " +
                           "INNER JOIN sinhvien ON lop.MaLop = sinhvien.MaLop";

            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);
            db.CloseConnection();

            return ds;
        }

        //public DataTable LayDanhSachTTSinhVien(string uid, string pass)
        //{
        //    DataTable sv = new DataTable();

        //    string query = "SELECT sinhvien.MaSV, sinhvien.HoTen, sinhvien.NgaySinh, sinhvien.GioiTinh, " +
        //                 "sinhvien.SDT, sinhvien.DiaChi, sinhvien.MaLop FROM sinhvien " + // Thêm khoảng trắng giữa "sinhvien" và "INNER JOIN"
        //                 "INNER JOIN tk_sinhvien  ON sinhvien.MaSV = tk_sinhvien.Ma_SV " +
        //                 "WHERE tk_sinhvien.uid = @uid AND tk_sinhvien.pass = @pass";


        //    MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
        //    cmd.Parameters.AddWithValue("@uid", uid);
        //    cmd.Parameters.AddWithValue("@pass", pass);

        //    db.OpenConnection();
        //    MySqlDataReader reader = cmd.ExecuteReader();
        //    sv.Load(reader);
        //    db.CloseConnection();

        //    return sv;
        //}


    }
}
