using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuanLiSinhVien;
using System.Windows.Forms;

namespace QuanLiSinhVien_UnitTest
{
    [TestClass]
    public class QLKhoa_UnitTest
    {
        [TestMethod]
        public void Test_ThemKhoa()
        {
            // Arrange: Khởi tạo đối tượng Form và các giá trị cần thiết
            Khoa sv_Form = new Khoa();
            sv_Form.txtMaKhoa.Text = "MK03";
            sv_Form.txtTenKhoa.Text = "Ngoai Ngu";


            // Act: Gọi hàm btnThem_Click
            sv_Form.btnThem_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void Test_SuaKhoa()
        {
            Khoa sv_Form = new Khoa();
            sv_Form.dataGridView_Khoa.Columns.Add("MaKhoa", "Ma Khoa");
            sv_Form.dataGridView_Khoa.Columns.Add("TenKhoa", "Tên Khoa");


            // Giả sử có ít nhất một dòng dữ liệu
            sv_Form.dataGridView_Khoa.Rows.Add(new object[]
            {"MK03", "Ngoai Ngu"});

            // Chọn dòng đầu tiên để sửa
            sv_Form.dataGridView_Khoa.CurrentCell = sv_Form.dataGridView_Khoa.Rows[0].Cells[0];

            // Gán dữ liệu giả định cho các controls trong form
            sv_Form.txtMaKhoa.Text = "MK03";
            sv_Form.txtTenKhoa.Text = "Ngoai Ngu";

            // Act: Gọi hàm btnSua_Click
            sv_Form.btnSua_Click(null, EventArgs.Empty);
        }

        [TestMethod]
        public void Test_XoaKhoa()
        {
            Khoa sv_Form = new Khoa();

            DataGridView dataGridView = new DataGridView();
            dataGridView.Columns.Add("MaKhoa", "Mã Khoa");
            dataGridView.Columns.Add("TenKhoa", "Ten Khoa");

            // Thêm dòng dữ liệu giả vào DataGridView
            dataGridView.Rows.Add("MK03", "Ngoai Ngu");

            // Gán DataGridView giả cho dataGridView_Khoa của đối tượng Khoa
            sv_Form.dataGridView_Khoa = dataGridView;

            // Chọn dòng đầu tiên để xóa
            sv_Form.dataGridView_Khoa.CurrentCell = sv_Form.dataGridView_Khoa.Rows[0].Cells[0];

            // Act: Gọi hàm btnXoa_Click
            sv_Form.btnXoa_Click(null, EventArgs.Empty);
        }


        [TestMethod]
        public void Test_TimKiemKhoa()
        {

            Khoa sv_Form = new Khoa();
            sv_Form.txtMaKhoa.Text = "MK03";

            // Tìm kiếm với từ khóa là tên sinh viên vừa thêm
            string tuKhoa = "MK03";

            // Act: Gọi hàm btnTimKiem_Click
            sv_Form.txtTuKhoa.Text = tuKhoa;
            sv_Form.btnTimKiem_Click(null, EventArgs.Empty);
        }
    }
}
