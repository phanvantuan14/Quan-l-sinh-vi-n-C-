using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuanLiSinhVien;
using System.Windows.Forms;

namespace QuanLiSinhVien_UnitTest
{
    [TestClass]
    public class QLSV_UnitTest
    {
        [TestMethod]
        public void Test_ThemSinhVien()
        {
            // Arrange: Khởi tạo đối tượng Form và các giá trị cần thiết
            SinhVien sv_Form = new SinhVien();
            sv_Form.txtHoTen.Text = "Nguyen Van A";
            sv_Form.dateTimeP_NgaySinh.Value = new DateTime(2000, 1, 1);
            sv_Form.radioB_Nam.Checked = true; 
            sv_Form.txtSDT.Text = "0123456789";
            sv_Form.txtDiaChi.Text = "123 ABC Street";
            sv_Form.comboBox_SV.Text = "k19c"; 

            // Act: Gọi hàm btnThem_Click
            sv_Form.btnThem_Click(null, EventArgs.Empty); 
        }

        [TestMethod]
        public void Test_SuaSinhVien()
        {
            SinhVien sv_Form = new SinhVien();
            sv_Form.dataGridView_SinhVien.Columns.Add("MaSV", "Mã SV");
            sv_Form.dataGridView_SinhVien.Columns.Add("HoTen", "Tên SV");
            sv_Form.dataGridView_SinhVien.Columns.Add("NgaySinh", "Ngày Sinh");
            sv_Form.dataGridView_SinhVien.Columns.Add("GioiTinh", "Giới Tính");
            sv_Form.dataGridView_SinhVien.Columns.Add("SDT", "Số Điện Thoại");
            sv_Form.dataGridView_SinhVien.Columns.Add("DiaChi", "Địa Chỉ");
            sv_Form.dataGridView_SinhVien.Columns.Add("MaLop", "Mã Lớp");
       
            // Giả sử có ít nhất một dòng dữ liệu
            sv_Form.dataGridView_SinhVien.Rows.Add(new object[] 
            { 1, "Nguyen Van A", new DateTime(2000, 1, 1), "Nam", "0123456789", "123 ABC Street", "k19c" });

            // Chọn dòng đầu tiên để sửa
            sv_Form.dataGridView_SinhVien.CurrentCell = sv_Form.dataGridView_SinhVien.Rows[0].Cells[0];

            // Gán dữ liệu giả định cho các controls trong form
            sv_Form.txtHoTen.Text = "Nguyen Van B";
            sv_Form.dateTimeP_NgaySinh.Value = new DateTime(1999, 1, 1);
            sv_Form.radioB_Nu.Checked = true;
            sv_Form.txtSDT.Text = "0987654321";
            sv_Form.txtDiaChi.Text = "456 XYZ Street";
            sv_Form.comboBox_SV.Text = "k19c";

            // Act: Gọi hàm btnSua_Click
            sv_Form.btnSua_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void Test_XoaSinhVien()
        {
            SinhVien sv_Form = new SinhVien();

            DataGridView dataGridView = new DataGridView();
            dataGridView.Columns.Add("MaSV", "Mã SV");
            dataGridView.Columns.Add("HoTen", "Tên SV");
            dataGridView.Columns.Add("NgaySinh", "Ngày Sinh");
            dataGridView.Columns.Add("GioiTinh", "Giới Tính");
            dataGridView.Columns.Add("SDT", "Số Điện Thoại");
            dataGridView.Columns.Add("DiaChi", "Địa Chỉ");
            dataGridView.Columns.Add("MaLop", "Mã Lớp");

            // Thêm dòng dữ liệu giả vào DataGridView
            dataGridView.Rows.Add(21,"Nguyen Van A", new DateTime(2000, 1, 1), "Nam", "0123456789", "123 ABC Street", "k19c");

            // Gán DataGridView giả cho dataGridView_SinhVien của đối tượng SinhVien
            sv_Form.dataGridView_SinhVien = dataGridView;

            // Chọn dòng đầu tiên để xóa
            sv_Form.dataGridView_SinhVien.CurrentCell = sv_Form.dataGridView_SinhVien.Rows[0].Cells[0];

            // Act: Gọi hàm btnXoa_Click
            sv_Form.btnXoa_Click(null, EventArgs.Empty);
        }


        [TestMethod]
        public void Test_TimKiemSinhVien()
        {
          
            SinhVien sv_Form = new SinhVien();
            sv_Form.txtHoTen.Text = "Nguyen Van A";

            // Tìm kiếm với từ khóa là tên sinh viên vừa thêm
            string tuKhoa = "Nguyen Van A";

            // Act: Gọi hàm btnTimKiem_Click
            sv_Form.txtTuKhoa.Text = tuKhoa;
            sv_Form.btnTimKiem_Click(null, EventArgs.Empty);
        }

    }
}
