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
    public partial class Khoa : Form
    {
        KHOA_DB khoa_DB = new KHOA_DB();
        public Khoa()
        {
            InitializeComponent();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            dataGridView_Khoa.DataSource = khoa_DB.LayDanhSachKhoa();

            dataGridView_Khoa.Columns["MaKhoa"].HeaderText = "Mã Khoa";
            dataGridView_Khoa.Columns["TenKhoa"].HeaderText = "Tên Khoa";

        }

        public void btnThem_Click(object sender, EventArgs e)
        {
            string makhoa = txtMaKhoa.Text;
            string tenkhoa = txtTenKhoa.Text;
     

            if (KiemTraThongTinNhap())
            {
                if (khoa_DB.KiemTraTonTaiKhoa(makhoa))
                {
                    MessageBox.Show("Mã khoa đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (khoa_DB.themKhoa(makhoa, tenkhoa))
                    {
                        dataGridView_Khoa.DataSource = khoa_DB.LayDanhSachKhoa();
                        MessageBox.Show("Thêm khoa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) ||
                string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                return false;
            }

            return true; // Trả về true nếu tất cả các TextBox đều không rỗng

        }

        public void btnSua_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_Khoa.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView_Khoa.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_Khoa.Rows[rowIndex];

                if (selectedRow.Cells["MaKhoa"].Value == DBNull.Value)
                {
                    MessageBox.Show("Không thể sửa thông tin vì không có Mã Khoa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string makhoa = txtMaKhoa.Text;
                string tenkhoa = txtTenKhoa.Text;

                if (KiemTraThongTinNhap())
                {
                    if (khoa_DB.suaThongTinKhoa(makhoa, tenkhoa))
                    {
                        dataGridView_Khoa.DataSource = khoa_DB.LayDanhSachKhoa();
                        MessageBox.Show("Sửa thông tin khoa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin khoa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            int rowIndex = dataGridView_Khoa.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView_Khoa.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_Khoa.Rows[rowIndex];

                if (selectedRow.Cells["MaKhoa"].Value == DBNull.Value)
                {
                    MessageBox.Show("Không thể xóa khoa vì không có Mã Khoa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string makhoa = selectedRow.Cells["MaKhoa"].Value.ToString(); // Chuyển đổi thành kiểu string

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (khoa_DB.xoaKhoa(makhoa))
                    {
                        dataGridView_Khoa.DataSource = khoa_DB.LayDanhSachKhoa();
                        MessageBox.Show("Xóa khoa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa khoa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim();

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                DataTable searchResult = khoa_DB.TimKiemKhoa(tuKhoa);

                if (searchResult.Rows.Count > 0)
                {
                    dataGridView_Khoa.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("Không có khoa nào được tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Text = string.Empty;
            txtTenKhoa.Text = string.Empty;
        }

        private void dataGridView_Khoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < dataGridView_Khoa.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_Khoa.Rows[rowIndex];
                if (selectedRow.Cells["MaKhoa"].Value == DBNull.Value ||
                    selectedRow.Cells["TenKhoa"].Value == DBNull.Value)
                {
                    return;
                }
                txtMaKhoa.Text = selectedRow.Cells["MaKhoa"].Value.ToString();
                txtTenKhoa.Text = selectedRow.Cells["TenKhoa"].Value.ToString();

            }
        }
    }
}
