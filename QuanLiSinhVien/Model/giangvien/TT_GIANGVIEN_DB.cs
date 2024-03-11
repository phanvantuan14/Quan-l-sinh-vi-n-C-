using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model.giangvien
{
    class TT_GIANGVIEN_DB
    {
        ConnectMySql db = new ConnectMySql();
        public DataTable LayDanhSachTTGiangVien(string uid, string pass)
        {
            DataTable sv = new DataTable();

            string query = "SELECT giangvien.ID, giangvien.HoTen, giangvien.NgaySinh, giangvien.GioiTinh, " +
               "giangvien.SDT, giangvien.DiaChi, khoa.TenKhoa, monhoc.TenMH " +
               "FROM giangvien " +
               "INNER JOIN khoa ON giangvien.MaKhoa = khoa.MaKhoa " +
               "INNER JOIN monhoc ON giangvien.MaMH = monhoc.MaMH " +
               "INNER JOIN tk_giangvien ON giangvien.ID = tk_giangvien.MaGV " +
               "WHERE tk_giangvien.uid = @uid AND tk_giangvien.pass = @pass";



            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@pass", pass);

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            sv.Load(reader);
            db.CloseConnection();

            return sv;
        }
    }
}
