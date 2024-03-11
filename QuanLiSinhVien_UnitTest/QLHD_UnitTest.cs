using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuanLiSinhVien;
using System.Windows.Forms;

namespace QuanLiSinhVien_UnitTest
{
    [TestClass]
    public class QLHD_UnitTest
    {
        [TestMethod]
        public void Test_ThemHoatDong()
        {
        
            HoatDong sv_Form = new HoatDong();
            sv_Form.txtTenHD.Text = "Nguyen S";
            sv_Form.dateTimeP_BD.Value = new DateTime(2024, 01, 01);
            sv_Form.dateTimeP_KT.Value = new DateTime(2024, 01, 02);
            sv_Form.txtDiaChi.Text = "123 ABC Street";
            sv_Form.txtMaSV.Text ="1";

          
            sv_Form.btnThem_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void Test_SuaHoatDong()
        {
            HoatDong sv_Form = new HoatDong();
            sv_Form.dataGridView_HD.Columns.Add("ID", "Mã Khoa");
            sv_Form.dataGridView_HD.Columns.Add("TenHD", "Tên SV");
            sv_Form.dataGridView_HD.Columns.Add("NgayBD", "Ngày Sinh");
            sv_Form.dataGridView_HD.Columns.Add("NgayKT", "Ngày Sinh");
            sv_Form.dataGridView_HD.Columns.Add("DiaChi", "Địa Chỉ");
            sv_Form.dataGridView_HD.Columns.Add("MaLop", "Mã Lớp");

          
            sv_Form.dataGridView_HD.Rows.Add(new object[]
            { 3, "Nguyen S", new DateTime(2024, 01, 01), new DateTime(2024, 01, 01),"123 ABC Street", "1" });

          
            sv_Form.dataGridView_HD.CurrentCell = sv_Form.dataGridView_HD.Rows[0].Cells[0];

         
            sv_Form.txtTenHD.Text = "Nguyen S";
            sv_Form.dateTimeP_BD.Value = new DateTime(2024, 01, 01);
            sv_Form.dateTimeP_KT.Value = new DateTime(2024, 01, 02);
            sv_Form.txtDiaChi.Text = "123 ABC Street";
            sv_Form.txtMaSV.Text = "1";

          
            sv_Form.btnSua_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void Test_XoaHoatDong()
        {
            
            HoatDong sv_Form = new HoatDong();
            DataGridViewRow row = new DataGridViewRow();
            sv_Form.dataGridView_HD.Columns.Add("ID", "Mã Khoa");
            sv_Form.dataGridView_HD.Columns.Add("TenHD", "Tên SV");
            sv_Form.dataGridView_HD.Columns.Add("NgayBD", "Ngày Sinh");
            sv_Form.dataGridView_HD.Columns.Add("NgayKT", "Ngày Sinh");
            sv_Form.dataGridView_HD.Columns.Add("DiaChi", "Địa Chỉ");
            sv_Form.dataGridView_HD.Columns.Add("MaLop", "Mã Lớp");

            _ =sv_Form.dataGridView_HD.Rows.Add(4, "Nguyen J", new DateTime(2024, 01, 01), new DateTime(2024, 01, 02), "13 ABC Street", "1");

            if (sv_Form.dataGridView_HD.Rows.Count > 0)
            {
                sv_Form.dataGridView_HD.CurrentCell = sv_Form.dataGridView_HD.Rows[0].Cells[0];
            }
            sv_Form.btnXoa_Click(null, EventArgs.Empty);  
        }



        [TestMethod]
        public void Test_TimKiemHoatDong()
        {

            HoatDong sv_Form = new HoatDong();
            sv_Form.txtTenHD.Text = "Nguyen S";
        

            string tuKhoa = "Nguyen S";

            sv_Form.txtTuKhoa.Text = tuKhoa;
            sv_Form.btnTimKiem_Click(null, EventArgs.Empty);
        }

    }
}
