using QuanLiSinhVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLiSinhVien
{
    public partial class ThongKe : Form
    {
        SINHVIEN_DB sv_DB = new SINHVIEN_DB();
        GIANGVIEN_DB gv_DB = new GIANGVIEN_DB();
        KHOA_DB khoa_DB = new KHOA_DB();
        LOP_DB lop_DB = new LOP_DB();
        MONHOC_DB monhoc_DB = new MONHOC_DB();
        HOATDONG_DB hd_DB = new HOATDONG_DB();
        DIEM_DB diem_DB = new DIEM_DB();
        THONGKE_DB tk_DB = new THONGKE_DB();

        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            SoLuongSV();
            SoLuongGV();
            SoLuongKhoa();
            SoLuongLop();
            SoLuongMonHoc();
            SoLuongHoatDong();
            SoLuongSVDat();
            SoLuongSVTruot();
            Chart_ThongKe();
        }

        private void SoLuongSV()
        {
            int soLuongSinhVien = sv_DB.LaySoLuongSinhVien();
            lbSoSV.Text = $"{soLuongSinhVien}";
        }
        private void SoLuongGV()
        {
            int soLuongGV = gv_DB.LaySoLuongGiangVien();
            lbSoGV.Text = $"{soLuongGV}";
        }
        private void SoLuongKhoa()
        {
            int soLuongKhoa = khoa_DB.LaySoLuongKhoa();
            lbSoKhoa.Text = $"{soLuongKhoa}";
        }
        private void SoLuongLop()
        {
            int soLuongLop = lop_DB.LaySoLuongLop();
            lbSoLop.Text = $"{soLuongLop}";
        }
        private void SoLuongMonHoc()
        {
            int soLuongMonHoc = monhoc_DB.LaySoLuongMH();
            lbSoMon.Text = $"{soLuongMonHoc}";
        }
        private void SoLuongHoatDong()
        {
            int soLuongHoatDong = hd_DB.LaySoLuongHD();
            lbSoHoatDong.Text = $"{soLuongHoatDong}";
        }
        private void SoLuongSVDat()
        {
            int soLuongSVDat = diem_DB.LaySoLuongSinhVienDat();
            lbSoSVDat.Text = $"{soLuongSVDat}";
        }
        private void SoLuongSVTruot()
        {
            int soLuongHoatDong = diem_DB.LaySoLuongSinhVienKhongDat();
            lbSoSVTruot.Text = $"{soLuongHoatDong}";
        }


        private void Chart_ThongKe()
        {
            // Xóa các dữ liệu cũ trên biểu đồ (nếu có)
            chart_ThongKe.Series.Clear();

            // Tạo một chuỗi dữ liệu mới cho biểu đồ
            Series series = new Series("Thống kê", (int)SeriesChartType.Column);

            // Thêm dữ liệu vào chuỗi
            series.Points.AddXY("Sinh Viên", int.Parse(lbSoSV.Text));
            series.Points.AddXY("Giảng Viên", int.Parse(lbSoGV.Text));
            series.Points.AddXY("Khóa", int.Parse(lbSoKhoa.Text));
            series.Points.AddXY("Lớp", int.Parse(lbSoLop.Text));
            series.Points.AddXY("Môn Học", int.Parse(lbSoMon.Text));
            series.Points.AddXY("Hoạt Động", int.Parse(lbSoHoatDong.Text));
            series.Points.AddXY("Số SV Đạt", int.Parse(lbSoSVDat.Text));
            series.Points.AddXY("Số SV Trượt", int.Parse(lbSoSVTruot.Text));

            chart_ThongKe.Series.Add(series);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Lấy thông tin thống kê mới từ các đối tượng giao diện hoặc từ dữ liệu khác trong ứng dụng của bạn
            int soSV = int.Parse(lbSoSV.Text);
            int soKhoa = int.Parse(lbSoKhoa.Text);
            int soLop = int.Parse(lbSoLop.Text);
            int soHD = int.Parse(lbSoHoatDong.Text);
            int SVDat = int.Parse(lbSoSVDat.Text);
            int SVTruot = int.Parse(lbSoSVTruot.Text);
            int soGV = int.Parse(lbSoGV.Text);
            int soMH = int.Parse(lbSoMon.Text);

            // Gọi phương thức UpdateThongTinThongKe để cập nhật dữ liệu vào cơ sở dữ liệu
            bool result = tk_DB.UpdateThongTinThongKe(soSV, soKhoa, soLop, soHD, SVDat, SVTruot,soGV, soMH);

            // Kiểm tra kết quả và thông báo cho người dùng
            if (result)
            {
                MessageBox.Show("Cập nhật thông tin thống kê thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thống kê thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
