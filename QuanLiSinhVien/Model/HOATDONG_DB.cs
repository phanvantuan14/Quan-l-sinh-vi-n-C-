using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuanLiSinhVien.Model
{
    class HOATDONG_DB
    {
        ConnectMySql db = new ConnectMySql();

        public bool themHoatDong(string tenHD, DateTime ngayBD, DateTime ngayKT, string diachi, string malop)
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `hoatdong`(`TenHD`, `NgayBD`, `NgayKT`, `DiaChi`,`MaLop`) VALUES (@tenHD,@ngayBD,@ngayKT,@diachi,@malop)", db.getConnection());

            command.Parameters.Add("@tenHD", MySqlDbType.VarChar).Value = tenHD;
            command.Parameters.Add("@ngayBD", MySqlDbType.Date).Value = ngayBD;
            command.Parameters.Add("@ngayKT", MySqlDbType.Date).Value = ngayKT;
            command.Parameters.Add("@diachi", MySqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@malop", MySqlDbType.VarChar).Value = malop;
       

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

        public bool suaThongTinHoatDong(string tenHD, DateTime ngayBD, DateTime ngayKT, string diachi, string malop, int maHD)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `hoatdong` SET `TenHD`= @tenHD,`NgayBD`= @ngayBD,`NgayKT`= @ngayKT,`DiaChi`= @diachi, `MaLop`= @malop WHERE `id`= @maHD", db.getConnection());
            command.Parameters.Add("@tenHD", MySqlDbType.VarChar).Value = tenHD;
            command.Parameters.Add("@ngayBD", MySqlDbType.Date).Value = ngayBD;
            command.Parameters.Add("@ngayKT", MySqlDbType.Date).Value = ngayKT;
            command.Parameters.Add("@diachi", MySqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@malop", MySqlDbType.VarChar).Value = malop;
   
            command.Parameters.Add("@maHD", MySqlDbType.Int32).Value = maHD;

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

        public bool xoaHoatDong(int maHD)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM hoatdong WHERE id = @maHD", db.getConnection());
            command.Parameters.Add("@maHD", MySqlDbType.Int32).Value = maHD;

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

        public DataTable TimKiemHoatDong(string tuKhoa)
        {
            DataTable ds = new DataTable();

            string query = "SELECT * FROM hoatdong WHERE TenHD LIKE @tuKhoa";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.Add("@tuKhoa", MySqlDbType.VarChar).Value = "%" + tuKhoa + "%";

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);

            db.CloseConnection();

            return ds;
        }

     
        public bool KiemTraTonTaiMalop(string malop)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM `lop` WHERE `MaLop` = @malop", db.getConnection());
            command.Parameters.Add("@malop", MySqlDbType.VarChar).Value = malop;


            db.OpenConnection();
            int countSV = Convert.ToInt32(command.ExecuteScalar());
            db.CloseConnection();

            return countSV > 0;
        }

        public bool KiemTraTonTaiHoatDong(string tenHoatDong, DateTime ngayBatDau, DateTime ngayKetThuc, string diaChi, string malop)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM hoatdong WHERE TenHD = @tenHoatDong " +
                "AND NgayBD = @ngayBatDau AND NgayKT = @ngayKetThuc AND DiaChi = @diaChi And MaLop = @malop", db.getConnection());
            command.Parameters.Add("@tenHoatDong", MySqlDbType.VarChar).Value = tenHoatDong;
            command.Parameters.Add("@ngayBatDau", MySqlDbType.Date).Value = ngayBatDau;
            command.Parameters.Add("@ngayKetThuc", MySqlDbType.Date).Value = ngayKetThuc;
            command.Parameters.Add("@diaChi", MySqlDbType.VarChar).Value = diaChi;
            command.Parameters.Add("@malop", MySqlDbType.VarChar).Value = malop;

            db.OpenConnection();
            int count = Convert.ToInt32(command.ExecuteScalar());
            db.CloseConnection();

            return count > 0; // Trả về true nếu có ít nhất một bản ghi phù hợp
        }

        public int LaySoLuongHD()
        {
            string query = "SELECT COUNT(*) FROM hoatdong";
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

        public DataTable LayDanhSachHoatDong()
        {
            DataTable ds = new DataTable();

            string query = "SELECT hoatdong.ID, hoatdong.TenHD, hoatdong.NgayBD, hoatdong.NgayKT, hoatdong.DiaChi, " +
                           "hoatdong.MaLop, lop.TenLop " +
                           "FROM lop " +
                           "INNER JOIN hoatdong ON lop.MaLop = hoatdong.MaLop";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);
            db.CloseConnection();

            return ds;
        }
    }
}
