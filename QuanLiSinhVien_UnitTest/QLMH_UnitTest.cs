using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuanLiSinhVien;
using System.Windows.Forms;

namespace QuanLiSinhVien_UnitTest
{
    [TestClass]
    public class QLMH_UnitTest
    {
        [TestMethod]
        public void Test_ThemMH()
        {
            MonHoc sv_Form = new MonHoc();
            sv_Form.txtMaMH.Text = "MH05";
            sv_Form.txtTenMH.Text = "Ngoai Ngu";
            sv_Form.txtTinChi.Text = "3";
            sv_Form.txtMaSV.Text = "1";
            sv_Form.txtMaGV.Text = "9";


            sv_Form.btnThem_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void Test_SuaMH()
        {
            MonHoc sv_Form = new MonHoc();
            sv_Form.dataGridView_MH.Columns.Add("MaMH", "Ma MH");
            sv_Form.dataGridView_MH.Columns.Add("TenMH", "Tên MH");
            sv_Form.dataGridView_MH.Columns.Add("SoTinChi", "STC");
            sv_Form.dataGridView_MH.Columns.Add("MaSV", "Ma SV");
            sv_Form.dataGridView_MH.Columns.Add("MaGV", "Ma GV");

            sv_Form.dataGridView_MH.Rows.Add(new object[]
            {"MH05", "Ngoai Ngu",3, 1,9});

            sv_Form.dataGridView_MH.CurrentCell = sv_Form.dataGridView_MH.Rows[0].Cells[0];

            sv_Form.txtMaMH.Text = "MH05";
            sv_Form.txtTenMH.Text = "Ngoai Ngu";
            sv_Form.txtTinChi.Text = "3";
            sv_Form.txtMaSV.Text = "1";
            sv_Form.txtMaGV.Text = "9";

            sv_Form.btnSua_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void Test_XoaMH()
        {
            MonHoc sv_Form = new MonHoc();

            sv_Form.dataGridView_MH.Columns.Add("MaMH", "Ma MH");
            sv_Form.dataGridView_MH.Columns.Add("TenMH", "Tên MH");
            sv_Form.dataGridView_MH.Columns.Add("SoTinChi", "STC");

            _ = sv_Form.dataGridView_MH.Rows.Add("MH06", "Dong thoi gian", 2, 17, 9);

            if (sv_Form.dataGridView_MH.Rows.Count > 0)
            {
                sv_Form.dataGridView_MH.CurrentCell = sv_Form.dataGridView_MH.Rows[0].Cells[0];
            }

            sv_Form.btnXoa_Click(null, EventArgs.Empty);

         
        }




        [TestMethod]
        public void Test_TimKiemMH()
        {

            MonHoc sv_Form = new MonHoc();
            sv_Form.txtMaMH.Text = "MH03";

            // Tìm kiếm với từ khóa là tên sinh viên vừa thêm
            string tuMH = "MH03";

            // Act: Gọi hàm btnTimKiem_Click
            sv_Form.txtTuKhoa.Text = tuMH;
            sv_Form.btnTimKiem_Click(null, EventArgs.Empty);
        }
    }
}
