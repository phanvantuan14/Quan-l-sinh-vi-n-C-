using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model.sinhvien
{
    class TT_SINHVIEN_DB
    {
        ConnectMySql db = new ConnectMySql();
        public DataTable LayDanhSachTTSinhVien(string uid, string pass)
        {
            DataTable sv = new DataTable();

            string query = "SELECT sinhvien.MaSV, sinhvien.HoTen, sinhvien.NgaySinh, sinhvien.GioiTinh, " +
                "sinhvien.SDT, sinhvien.DiaChi, lop.TenLop " +
                "FROM sinhvien " +
                "INNER JOIN lop ON sinhvien.MaLop = lop.MaLop " +
                "INNER JOIN tk_sinhvien ON sinhvien.MaSV = tk_sinhvien.Ma_SV " +
                "WHERE tk_sinhvien.uid = @uid AND tk_sinhvien.pass = @pass";


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
