using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuanLiSinhVien;
using System.Windows.Forms;

namespace QuanLiSinhVien_UnitTest
{
    [TestClass]
    public class QLLop_UnitTest
    {
        [TestMethod]
        public void Test_ThemLop()
        {
            Lop sv_Form = new Lop();
            sv_Form.txtMaLop.Text = "k19d";
            sv_Form.comboBox_Khoa.Text = "MK01";
            sv_Form.txtTenLop.Text = "Cntt-k19d";


            sv_Form.btnThem_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void Test_SuaLop()
        {
            Lop sv_Form = new Lop();
            sv_Form.dataGridView_Lop.Columns.Add("MaLop", "Ma Lop");
            sv_Form.dataGridView_Lop.Columns.Add("MaKhoa", "Tên Khoa");
            sv_Form.dataGridView_Lop.Columns.Add("TenLop", "Tên Lop");


            sv_Form.dataGridView_Lop.Rows.Add(new object[]
            {"k19d","MK01", "Cntt-k19d"});

            sv_Form.dataGridView_Lop.CurrentCell = sv_Form.dataGridView_Lop.Rows[0].Cells[0];

            sv_Form.txtMaLop.Text = "k19d";
            sv_Form.comboBox_Khoa.Text = "MK01";
            sv_Form.txtTenLop.Text = "Cntt-k19d";

            sv_Form.btnSua_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void Test_XoaLop()
        {
            Lop sv_Form = new Lop();

            DataGridView dataGridView = new DataGridView();
            sv_Form.dataGridView_Lop.Columns.Add("MaLop", "Ma Lop");
            sv_Form.dataGridView_Lop.Columns.Add("MaKhoa", "Tên Khoa");
            sv_Form.dataGridView_Lop.Columns.Add("TenLop", "Tên Lop");

            _ = sv_Form.dataGridView_Lop.Rows.Add("K19H", "MK01", "CNTT-K19H");

            if (sv_Form.dataGridView_Lop.Rows.Count > 0)
            {
                sv_Form.dataGridView_Lop.CurrentCell = sv_Form.dataGridView_Lop.Rows[0].Cells[0];
            }

            sv_Form.btnXoa_Click(null, EventArgs.Empty);
        }


        [TestMethod]
        public void Test_TimKiemLop()
        {

            Lop sv_Form = new Lop();
            sv_Form.txtMaLop.Text = "k19d";
        

            string tuLop = "k19d";

            sv_Form.txtTuKhoa.Text = tuLop;
            sv_Form.btnTimKiem_Click(null, EventArgs.Empty);
        }
    }
}
