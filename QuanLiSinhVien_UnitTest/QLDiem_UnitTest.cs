using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuanLiSinhVien;
using System.Windows.Forms;

namespace QuanLiSinhVien_UnitTest
{
    [TestClass]
    public class QLDiem_UnitTest
    {
        
        [TestMethod]
        public void Test_ThemDiem()
        {
            Diem sv_Form = new Diem();
            sv_Form.txtMaSV.Text = "1";
            sv_Form.comboBox_Diem.Text = "MH01";
            sv_Form.txtDiem1.Text = "7";
            sv_Form.txtDiem2.Text = "7";


            sv_Form.btnThem_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void Test_SuaDiem()
        {
            Diem sv_Form = new Diem();
            sv_Form.dataGridView_Diem.Columns.Add("MaSV", "Ma SV");
            sv_Form.dataGridView_Diem.Columns.Add("MaMH", "Ma MH");
            sv_Form.dataGridView_Diem.Columns.Add("Diem1", "Diem 1");
            sv_Form.dataGridView_Diem.Columns.Add("Diem2", "Diem 2");

            sv_Form.dataGridView_Diem.Rows.Add(new object[]
            {1, "MH01", 7,7});

            sv_Form.dataGridView_Diem.CurrentCell = sv_Form.dataGridView_Diem.Rows[0].Cells[0];

            sv_Form.txtMaSV.Text = "1";
            sv_Form.comboBox_Diem.Text = "MH02";
            sv_Form.txtDiem1.Text = "7";
            sv_Form.txtDiem2.Text = "7";

            sv_Form.btnSua_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void Test_XoaDiem()
        {
            Diem sv_Form = new Diem();

            sv_Form.dataGridView_Diem.Columns.Add("MaSV", "Ma SV");
            sv_Form.dataGridView_Diem.Columns.Add("MaMH", "Ma MH");
            sv_Form.dataGridView_Diem.Columns.Add("Diem1", "Diem 1");
            sv_Form.dataGridView_Diem.Columns.Add("Diem2", "Diem 2");

            sv_Form.dataGridView_Diem.Rows.Add(22, "MH05", 7, 8);

            if (sv_Form.dataGridView_Diem.Rows.Count > 0)
            {
                sv_Form.dataGridView_Diem.CurrentCell = sv_Form.dataGridView_Diem.Rows[0].Cells[0];
            }

            sv_Form.btnXoa_Click(null, EventArgs.Empty);
        }



        [TestMethod]
        public void Test_TimKiemDiem()
        {

            Diem sv_Form = new Diem();
            sv_Form.txtMaSV.Text = "1";
           

            string tuDiem = "1";

            sv_Form.txtTuKhoa.Text = tuDiem;
            sv_Form.btnTimKiem_Click(null, EventArgs.Empty);
        }
    }
}
