using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model
{
    class THONGKE_DB
    {
        ConnectMySql db = new ConnectMySql();
        public bool UpdateThongTinThongKe(int soSV, int soKhoa, int soLop, int soHD, int SVDat, int SVTruot, int soGV, int soMH)
        {
            // Lấy dữ liệu hiện tại từ bảng `thongke`
            string query = "SELECT * FROM `thongke`";
            MySqlCommand selectCommand = new MySqlCommand(query, db.getConnection());
            db.OpenConnection();
            MySqlDataReader reader = selectCommand.ExecuteReader();
            if (reader.Read())
            {
                // Lấy giá trị hiện tại từ các cột của bảng `thongke`
                int currentSoSV = Convert.ToInt32(reader["TongSV"]);
                int currentSoKhoa = Convert.ToInt32(reader["TongKhoa"]);
                int currentSoLop = Convert.ToInt32(reader["TongLop"]);
                int currentSoHD = Convert.ToInt32(reader["TongHD"]);
                int currentSVDat = Convert.ToInt32(reader["SVDat"]);
                int currentSVTruot = Convert.ToInt32(reader["SVTruot"]);
                int currentSoGV = Convert.ToInt32(reader["TongGV"]);
                int currentSoMH = Convert.ToInt32(reader["TongMH"]);

                // Kiểm tra xem các giá trị đã cập nhật chưa
                if (currentSoSV == soSV && currentSoKhoa == soKhoa && currentSoLop == soLop &&
                    currentSoHD == soHD && currentSVDat == SVDat && currentSVTruot == SVTruot &&
                    currentSoGV == soGV && currentSoMH == soMH)
                {
                    // Đóng kết nối và trả về true để thông báo rằng dữ liệu đã được cập nhật
                    db.CloseConnection();
                    return true;
                }
            }
            db.CloseConnection();

            // Nếu không cập nhật thành công, thực hiện thêm dữ liệu mới vào bảng `thongke`
            MySqlCommand insertCommand = new MySqlCommand(
                "INSERT INTO `thongke` (`TongSV`, `TongLop`, `TongKhoa`, `TongHD`, `SVDat`, `SVTruot`, `TongGV`, `TongMH`) " +
                "VALUES (@TongSV, @TongLop, @TongKhoa, @TongHD, @SVDat, @SVTruot, @TongGV, @TongMH)",
                db.getConnection()
            );
            insertCommand.Parameters.Add("@TongSV", MySqlDbType.VarChar).Value = soSV;
            insertCommand.Parameters.Add("@TongLop", MySqlDbType.Int32).Value = soLop;
            insertCommand.Parameters.Add("@TongKhoa", MySqlDbType.Int32).Value = soKhoa;
            insertCommand.Parameters.Add("@TongHD", MySqlDbType.Int32).Value = soHD;
            insertCommand.Parameters.Add("@SVDat", MySqlDbType.Int32).Value = SVDat;
            insertCommand.Parameters.Add("@SVTruot", MySqlDbType.Int32).Value = SVTruot;
            insertCommand.Parameters.Add("@TongGV", MySqlDbType.VarChar).Value = soGV;
            insertCommand.Parameters.Add("@TongMH", MySqlDbType.VarChar).Value = soMH;

            db.OpenConnection();
            if (insertCommand.ExecuteNonQuery() == 1)
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

    }
}
