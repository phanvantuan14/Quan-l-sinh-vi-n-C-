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
    public partial class Lop : Form
    {
        LOP_DB lop_DB = new LOP_DB();
        KHOA_DB khoa_DB = new KHOA_DB();
        public Lop()
        {
            InitializeComponent();
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            comboBox_Khoa.DataSource = khoa_DB.LayDanhSachKhoa();
            comboBox_Khoa.DisplayMember = "label";
            comboBox_Khoa.ValueMember = "MaKhoa";

            dataGridView_Lop.DataSource = lop_DB.LayDanhSachLop();

            dataGridView_Lop.Columns["MaLop"].HeaderText = "Mã Lớp";
            dataGridView_Lop.Columns["TenLop"].HeaderText = "Tên Lớp";
            dataGridView_Lop.Columns["MaKhoa"].HeaderText = "Mã Khoa";
            dataGridView_Lop.Columns["TenKhoa"].HeaderText = "Tên Khoa";
        }

        public void btnThem_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string maKhoa = comboBox_Khoa.Text;
            string tenLop = txtTenLop.Text;


            if (KiemTraThongTinNhap())
            {
                if (lop_DB.KiemTraTonTaiMaLop(maLop))
                {
                    MessageBox.Show("Mã lớp đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (lop_DB.themLop(maLop, maKhoa, tenLop))
                    {
                        dataGridView_Lop.DataSource = lop_DB.LayDanhSachLop();
                        MessageBox.Show("Thêm lớp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) ||
                string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                return false;
            }

            return true; // Trả về true nếu tất cả các TextBox đều không rỗng

        }
        public void btnSua_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_Lop.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView_Lop.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_Lop.Rows[rowIndex];

                if (selectedRow.Cells["MaLop"].Value == DBNull.Value)
                {
                    MessageBox.Show("Không thể sửa thông tin vì không có mã lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

           
                string maLop = txtMaLop.Text;
                string maKhoa = comboBox_Khoa.Text;
                string tenLop = txtTenLop.Text;

                if (KiemTraThongTinNhap())
                {
                    if (lop_DB.suaThongTinLop(maLop, maKhoa, tenLop))
                    {
                        dataGridView_Lop.DataSource = lop_DB.LayDanhSachLop();
                        MessageBox.Show("Sửa thông tin lớp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin lớp không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            int rowIndex = dataGridView_Lop.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView_Lop.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_Lop.Rows[rowIndex];

                if (selectedRow.Cells["MaLop"].Value == DBNull.Value)
                {
                    MessageBox.Show("Không thể xóa lớp vì không có Mã lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maLop = selectedRow.Cells["MaLop"].Value.ToString();

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (lop_DB.xoaLop(maLop))
                    {
                        dataGridView_Lop.DataSource = lop_DB.LayDanhSachLop();
                        MessageBox.Show("Xóa lớp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa lớp không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim();

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                DataTable searchResult = lop_DB.TimKiemLop(tuKhoa);

                if (searchResult.Rows.Count > 0)
                {
                    dataGridView_Lop.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("Không có lớp nào được tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = string.Empty;
            comboBox_Khoa.Text = string.Empty;
            txtTenLop.Text = string.Empty;
        }

        private void dataGridView_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < dataGridView_Lop.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_Lop.Rows[rowIndex];
                if (selectedRow.Cells["MaLop"].Value == DBNull.Value ||
                    selectedRow.Cells["MaKhoa"].Value == DBNull.Value ||
                    selectedRow.Cells["TenLop"].Value == DBNull.Value)
                {
                    return;
                }
                txtMaLop.Text = selectedRow.Cells["MaLop"].Value.ToString();
                comboBox_Khoa.Text = selectedRow.Cells["MaKhoa"].Value.ToString();
                txtTenLop.Text = selectedRow.Cells["TenLop"].Value.ToString();

            }
        }
    }
}
