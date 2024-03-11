using QuanLiSinhVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    public partial class SinhVien : Form
    {
        SINHVIEN_DB sv_DB = new SINHVIEN_DB();
        LOP_DB lop_DB = new LOP_DB();


        public SinhVien()
        {
            InitializeComponent();
        }
        private void SinhVien_Load(object sender, EventArgs e)
        {
            comboBox_SV.DataSource = lop_DB.LayDanhSachLop();
            comboBox_SV.DisplayMember = "label";
            comboBox_SV.ValueMember = "MaLop";

            dataGridView_SinhVien.DataSource = sv_DB.LayDanhSachSinhVien();

            dataGridView_SinhVien.Columns["MaSV"].HeaderText = "Mã SV";
            dataGridView_SinhVien.Columns["HoTen"].HeaderText = "Họ Tên";
            dataGridView_SinhVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridView_SinhVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dataGridView_SinhVien.Columns["SDT"].HeaderText = "SDT";
            dataGridView_SinhVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridView_SinhVien.Columns["MaLop"].HeaderText = "Mã Lớp";
            dataGridView_SinhVien.Columns["TenLop"].HeaderText = "Tên Lớp";

        }
       
        public void btnThem_Click(object sender, EventArgs e)
        {
            string hote = txtHoTen.Text;
            DateTime ngaysinh = dateTimeP_NgaySinh.Value;
            string gioitinh = "Nam";
            string SDT = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            string malop = comboBox_SV.Text;
            if (radioB_Nu.Checked)
            {
                gioitinh = "Nữ";
            }

            int nam_sinh = dateTimeP_NgaySinh.Value.Year;
            int nam_hien_tai = DateTime.Now.Year;

            if (KiemTraThongTinNhap())
            {
                if (((nam_hien_tai - nam_sinh) < 10) || ((nam_hien_tai - nam_sinh) > 150))
                {
                    MessageBox.Show("Ngày sinh không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (sv_DB.KiemTraTonTaiSinhVien(hote, ngaysinh, gioitinh, SDT, diachi, malop))
                    {
                        MessageBox.Show("Sinh viên đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (!sv_DB.KiemTraTonTaiMaLop(malop))
                        {
                            MessageBox.Show("Mã lớp không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (sv_DB.themSinhVien(hote, ngaysinh, gioitinh, SDT, diachi, malop))
                        {
                            dataGridView_SinhVien.DataSource = sv_DB.LayDanhSachSinhVien();
                            MessageBox.Show("Thêm sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool KiemTraThongTinNhap()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(comboBox_SV.Text)||
                dateTimeP_NgaySinh.Value == dateTimeP_NgaySinh.MinDate||
                !radioB_Nam.Checked && !radioB_Nu.Checked)
            {
                return false; 
            }

            return true; // Trả về true nếu tất cả các TextBox đều không rỗng

        }

        public void dataGridView_SinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < dataGridView_SinhVien.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_SinhVien.Rows[rowIndex];
                if ( selectedRow.Cells["HoTen"].Value == DBNull.Value ||
                     selectedRow.Cells["NgaySinh"].Value == DBNull.Value ||
                     selectedRow.Cells["SDT"].Value == DBNull.Value ||
                     selectedRow.Cells["DiaChi"].Value == DBNull.Value ||
                     selectedRow.Cells["MaLop"].Value == DBNull.Value)
                {
                    return;
                }
                txtHoTen.Text = selectedRow.Cells["HoTen"].Value.ToString();
                dateTimeP_NgaySinh.Value = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value);
                txtSDT.Text = selectedRow.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                comboBox_SV.Text = selectedRow.Cells["MaLop"].Value.ToString();

                string gioiTinh = selectedRow.Cells["GioiTinh"].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    radioB_Nam.Checked = true;
                    radioB_Nu.Checked = false;
                }
                else if (gioiTinh == "Nữ")
                {
                    radioB_Nam.Checked = false;
                    radioB_Nu.Checked = true;
                }
            }
        }

        public void btnSua_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_SinhVien.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView_SinhVien.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_SinhVien.Rows[rowIndex];

                if (selectedRow.Cells["MaSV"].Value == DBNull.Value)
                {
                    MessageBox.Show("Không thể sửa thông tin vì không có Mã SV.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int masv;
                if (!int.TryParse(selectedRow.Cells["MaSV"].Value.ToString(), out masv))
                {
                    MessageBox.Show("Không thể sửa thông tin vì Mã SV không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hote = txtHoTen.Text;
                DateTime ngaysinh = dateTimeP_NgaySinh.Value;
                string gioitinh = radioB_Nam.Checked ? "Nam" : "Nữ";
                string SDT = txtSDT.Text;
                string diachi = txtDiaChi.Text;
                string malop = comboBox_SV.Text;

                int nam_sinh = dateTimeP_NgaySinh.Value.Year;
                int nam_hien_tai = DateTime.Now.Year;

                if (KiemTraThongTinNhap())
                {
                    if (((nam_hien_tai - nam_sinh) < 10) || ((nam_hien_tai - nam_sinh) > 150))
                    {
                        MessageBox.Show("Ngày sinh không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (sv_DB.KiemTraTonTaiSinhVien(hote, ngaysinh, gioitinh, SDT, diachi, malop))
                        {
                            MessageBox.Show("Sinh viên đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (!sv_DB.KiemTraTonTaiMaLop(malop))
                            {
                                MessageBox.Show("Mã lớp không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (sv_DB.suaThongTinSinhVien(hote, ngaysinh, gioitinh, SDT, diachi, malop, masv))
                            {
                                dataGridView_SinhVien.DataSource = sv_DB.LayDanhSachSinhVien();
                                MessageBox.Show("Sửa thông tin sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Sửa thông tin sinh viên không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void btnXoa_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_SinhVien.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView_SinhVien.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_SinhVien.Rows[rowIndex];

                if (selectedRow.Cells["MaSV"].Value == DBNull.Value)
                {
                    MessageBox.Show("Không thể xóa sinh viên vì không có Mã SV.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maSV;
                if (!int.TryParse(selectedRow.Cells["MaSV"].Value.ToString(), out maSV))
                {
                    MessageBox.Show("Không thể xóa sinh viên vì Mã SV không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (sv_DB.xoaSinhVien(maSV))
                    {
                        // Kiểm tra và thêm cột nếu cần thiết
                        if (dataGridView_SinhVien.Columns.Count == 0)
                        {
                            dataGridView_SinhVien.AutoGenerateColumns = true;
                            dataGridView_SinhVien.DataSource = sv_DB.LayDanhSachSinhVien();
                        }
                        else
                        {
                            dataGridView_SinhVien.DataSource = sv_DB.LayDanhSachSinhVien();
                        }

                        MessageBox.Show("Xóa sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa sinh viên không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim();

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                DataTable searchResult = sv_DB.TimKiemSinhVien(tuKhoa);

                if (searchResult.Rows.Count > 0)
                {
                    dataGridView_SinhVien.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("Không có sinh viên nào được tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = string.Empty;
            dateTimeP_NgaySinh.Value = DateTime.Now; 
            radioB_Nam.Checked = true;
            radioB_Nu.Checked = false; 
            txtSDT.Text = string.Empty; 
            txtDiaChi.Text = string.Empty; 
            comboBox_SV.Text = string.Empty; 
        }
    }
}
