using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuanLiGiangVien;
using System.Windows.Forms;

namespace QuanLiSinhVien_UnitTest
{
    [TestClass]
    public class QLGV_UnitTest
    {
        [TestMethod]
        public void Test_ThemGiangVien()
        {
            GiangVien gv_Form = new GiangVien();
            gv_Form.txtHoTen.Text = "Nguyen Van A";
            gv_Form.dateTimeP_NgaySinh.Value = new DateTime(2000, 1, 1);
            gv_Form.radioB_Nam.Checked = true;
            gv_Form.txtSDT.Text = "0123456789";
            gv_Form.txtDiaChi.Text = "123 ABC Street";
            gv_Form.comboBox_MaKhoa.Text = "MK01";
            gv_Form.comboBox__MaMH.Text = "MH01";

            gv_Form.btnThem_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void Test_SuaGiangVien()
        {
            GiangVien gv_Form = new GiangVien();
            DataGridView dataGridView = new DataGridView();
            gv_Form.dataGridView_GiangVien.Columns.Add("ID", "Mã GV");
            gv_Form.dataGridView_GiangVien.Columns.Add("HoTen", "Tên GV");
            gv_Form.dataGridView_GiangVien.Columns.Add("NgaySinh", "Ngày Sinh");
            gv_Form.dataGridView_GiangVien.Columns.Add("GioiTinh", "Giới Tính");
            gv_Form.dataGridView_GiangVien.Columns.Add("SDT", "Số Điện Thoại");
            gv_Form.dataGridView_GiangVien.Columns.Add("DiaChi", "Địa Chỉ");
            gv_Form.dataGridView_GiangVien.Columns.Add("MaKhoa", "Mã Khoa");
            gv_Form.dataGridView_GiangVien.Columns.Add("MaMH", "Mã MH");

            gv_Form.dataGridView_GiangVien.Rows.Add(new object[]
            { 10, "Nguyen Van A", new DateTime(2000, 1, 1), "Nam", "0123456789", "123 ABC Street", "MK01","MH01" });

            gv_Form.dataGridView_GiangVien.CurrentCell = gv_Form.dataGridView_GiangVien.Rows[0].Cells[0];

            gv_Form.txtHoTen.Text = "Nguyen Van B";
            gv_Form.dateTimeP_NgaySinh.Value = new DateTime(1999, 1, 1);
            gv_Form.radioB_Nu.Checked = true;
            gv_Form.txtSDT.Text = "0987654321";
            gv_Form.txtDiaChi.Text = "456 XYZ Street";
            gv_Form.comboBox_MaKhoa.Text = "MK01";
            gv_Form.comboBox__MaMH.Text = "MH01";

            gv_Form.btnSua_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void Test_XoaGiangVien()
        {
            GiangVien gv_Form = new GiangVien();

            DataGridView dataGridView = new DataGridView();

            dataGridView.Columns.Add("ID", "Mã GV");
            dataGridView.Columns.Add("HoTen", "Tên GV");
            dataGridView.Columns.Add("NgaySinh", "Ngày Sinh");
            dataGridView.Columns.Add("GioiTinh", "Giới Tính");
            dataGridView.Columns.Add("SDT", "Số Điện Thoại");
            dataGridView.Columns.Add("DiaChi", "Địa Chỉ");
            dataGridView.Columns.Add("MaKhoa", "Mã Khoa");
            dataGridView.Columns.Add("MaMH", "Mã MH");

            dataGridView.Rows.Add(11, "Nguyen Van G", new DateTime(2000, 1, 1), "Nam", "0123456789", "123 Street", "MK01", "MH01");

            gv_Form.dataGridView_GiangVien = dataGridView;

            if (dataGridView.Rows.Count > 0)
            {
                gv_Form.dataGridView_GiangVien.CurrentCell = dataGridView.Rows[0].Cells[0];
            }

            gv_Form.btnXoa_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void Test_TimKiemGiangVien()
        {
            GiangVien gv_Form = new GiangVien();
            gv_Form.txtHoTen.Text = "Nguyen Van A";

            // Tìm kiếm với từ khóa là tên sinh viên vừa thêm
            string tuKhoa = "Nguyen Van A";

            // Act: Gọi hàm btnTimKiem_Click
            gv_Form.txtTuKhoa.Text = tuKhoa;
            gv_Form.btnTimKiem_Click(null, EventArgs.Empty);
        }
    }
}
