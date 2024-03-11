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

namespace QuanLiSinhVien
{
    public partial class MonHoc : Form
    {
        MONHOC_DB khoa_DB = new MONHOC_DB();
        public MonHoc()
        {
            InitializeComponent();
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            dataGridView_MH.DataSource = khoa_DB.LayDanhSachMH();

            dataGridView_MH.Columns["TenSinhVien"].HeaderText = "Tên SV";
            dataGridView_MH.Columns["TenGiangVien"].HeaderText = "Tên GV";
            dataGridView_MH.Columns["MaMH"].HeaderText = "Mã Môn Học";
            dataGridView_MH.Columns["TenMH"].HeaderText = "Tên Môn Học";
            dataGridView_MH.Columns["SoTinChi"].HeaderText = "Số Tín Chỉ";
            dataGridView_MH.Columns["MaSV"].HeaderText = "Mã SV"; 
            dataGridView_MH.Columns["MaGV"].HeaderText = "Mã GV";
        }

        public void btnThem_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text;
            string tenMH = txtTenMH.Text;
            int soTC, maGV, maSV;

            // Kiểm tra và chuyển đổi giá trị từ TextBox sang kiểu int
            if ((!int.TryParse(txtTinChi.Text, out soTC)))
            {
                MessageBox.Show("Số tín chỉ nhập vào không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Không tiếp tục nếu không chuyển đổi được
            }
            if ((!int.TryParse(txtMaSV.Text, out maSV)))
            {
                MessageBox.Show("Mã sinh viên nhập vào không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Không tiếp tục nếu không chuyển đổi được
            }
            if ((!int.TryParse(txtMaGV.Text, out maGV)))
            {
                MessageBox.Show("Mã giảng viên nhập vào không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Không tiếp tục nếu không chuyển đổi được
            }

            if (KiemTraThongTinNhap())
            {
                if (khoa_DB.KiemTraTonTaiMonHoc(maMH))
                {
                    MessageBox.Show("Mã môn học đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!khoa_DB.KiemTraTonTaiMaSV(maSV))
                {
                    MessageBox.Show("Mã sinh viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!khoa_DB.KiemTraTonTaiMaGV(maGV))
                {
                    MessageBox.Show("Mã giảng viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (khoa_DB.themMH(maMH, tenMH, soTC, maSV, maGV))
                {
                    dataGridView_MH.DataSource = khoa_DB.LayDanhSachMH();
                    MessageBox.Show("Thêm môn học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool KiemTraThongTinNhap()
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text) ||
                string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                return false;
            }

            return true; // Trả về true nếu tất cả các TextBox đều không rỗng

        }

        public void btnSua_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_MH.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView_MH.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_MH.Rows[rowIndex];

                if (selectedRow.Cells["MaMH"].Value == DBNull.Value)
                {
                    MessageBox.Show("Không thể sửa thông tin vì không có mã môn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string maMH = txtMaMH.Text;
                string tenMH = txtTenMH.Text;
                int soTC, maGV, maSV;

                // Kiểm tra và chuyển đổi giá trị từ TextBox sang kiểu int
                if ((!int.TryParse(txtTinChi.Text, out soTC)))
                {
                    MessageBox.Show("Số tín chỉ nhập vào không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Không tiếp tục nếu không chuyển đổi được
                }
                if ((!int.TryParse(txtMaSV.Text, out maSV)))
                {
                    MessageBox.Show("Mã sinh viên nhập vào không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Không tiếp tục nếu không chuyển đổi được
                }
                if ((!int.TryParse(txtMaGV.Text, out maGV)))
                {
                    MessageBox.Show("Mã giảng viên nhập vào không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Không tiếp tục nếu không chuyển đổi được
                }

                if (KiemTraThongTinNhap())
                {
                    if (!khoa_DB.KiemTraTonTaiMaSV(maSV))
                    {
                        MessageBox.Show("Mã sinh viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!khoa_DB.KiemTraTonTaiMaGV(maGV))
                    {
                        MessageBox.Show("Mã giảng viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (khoa_DB.suaThongTinMH(maMH, tenMH, soTC, maSV, maGV))
                    {
                        dataGridView_MH.DataSource = khoa_DB.LayDanhSachMH();
                        MessageBox.Show("Sửa thông tin môn học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin môn học không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            int rowIndex = dataGridView_MH.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView_MH.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_MH.Rows[rowIndex];

                if (selectedRow.Cells["MaMH"].Value == DBNull.Value)
                {
                    MessageBox.Show("Không thể xóa môn học vì không có mã môn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maMH = selectedRow.Cells["MaMH"].Value.ToString();

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa môn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (khoa_DB.xoaMH(maMH))
                    {
                        dataGridView_MH.DataSource = khoa_DB.LayDanhSachMH();
                        MessageBox.Show("Xóa môn học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa môn học không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim();

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                DataTable searchResult = khoa_DB.TimKiemMH(tuKhoa);

                if (searchResult.Rows.Count > 0)
                {
                    dataGridView_MH.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("Không có môn học nào được tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaMH.Text = string.Empty;
            txtMaGV.Text = string.Empty;
            txtMaSV.Text = string.Empty;
            txtTenMH.Text = string.Empty;
            txtTinChi.Text = string.Empty;
        }

        private void dataGridView_MH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < dataGridView_MH.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_MH.Rows[rowIndex];
                if (selectedRow.Cells["MaMH"].Value == DBNull.Value ||
                    selectedRow.Cells["SoTinChi"].Value == DBNull.Value ||
                    selectedRow.Cells["MaSV"].Value == DBNull.Value ||
                    selectedRow.Cells["MaGV"].Value == DBNull.Value ||
                    selectedRow.Cells["TenMH"].Value == DBNull.Value)
                {
                    return;
                }
                txtMaMH.Text = selectedRow.Cells["MaMH"].Value.ToString();
                txtMaSV.Text = selectedRow.Cells["MaSV"].Value.ToString();
                txtMaGV.Text = selectedRow.Cells["MaGV"].Value.ToString();
                txtTenMH.Text = selectedRow.Cells["TenMH"].Value.ToString();
                txtTinChi.Text = selectedRow.Cells["SoTinChi"].Value.ToString();

            }
        }
    }
}
