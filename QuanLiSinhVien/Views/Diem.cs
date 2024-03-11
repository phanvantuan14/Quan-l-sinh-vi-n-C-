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
    public partial class Diem : Form
    {
        DIEM_DB diem_DB = new DIEM_DB();
        MONHOC_DB monhoc_DB = new MONHOC_DB();
        public Diem()
        {
            InitializeComponent();
        }

        private void Diem_Load(object sender, EventArgs e)
        {
            comboBox_Diem.DataSource = monhoc_DB.LayDanhSachMH();
            comboBox_Diem.DisplayMember = "label";
            comboBox_Diem.ValueMember = "MaMH";

            dataGridView_Diem.DataSource = diem_DB.LayDanhSachDiem();

            dataGridView_Diem.Columns["MaSV"].HeaderText = "Mã SV";
            dataGridView_Diem.Columns["HoTen"].HeaderText = "Họ Tên";
            dataGridView_Diem.Columns["MaMH"].HeaderText = "Mã MH";
            dataGridView_Diem.Columns["TenMH"].HeaderText = "Tên MH";
            dataGridView_Diem.Columns["Diem1"].HeaderText = "Điểm Kì 1";
            dataGridView_Diem.Columns["Diem2"].HeaderText = "Điểm Kì 2";
        }

        public void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string maMH = comboBox_Diem.Text;
            float diem1, diem2;

            // Kiểm tra và chuyển đổi giá trị từ TextBox sang kiểu float
            if (!float.TryParse(txtDiem1.Text, out diem1) || !float.TryParse(txtDiem2.Text, out diem2))
            {
                MessageBox.Show("Điểm nhập vào không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (KiemTraThongTinNhap())
            {
                if (float.TryParse(txtDiem1.Text.Replace(".", ","), out diem1) && float.TryParse(txtDiem2.Text.Replace(".", ","), out diem2))
                {
                    if (diem_DB.KiemTraTonTaiDiemSinhVien(maSV, maMH))
                    {
                        MessageBox.Show("Điểm sinh viên đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (!diem_DB.KiemTraTonTaiMaSV(maSV))
                        {
                            MessageBox.Show("Mã lớp không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (!diem_DB.KiemTraTonTaiMaMH(maMH))
                        {
                            MessageBox.Show("Mã môn học không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (diem_DB.themDiem(maSV, maMH, diem1, diem2))
                        {
                            dataGridView_Diem.DataSource = diem_DB.LayDanhSachDiem();
                            MessageBox.Show("Thêm điểm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Điểm nhập vào không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool KiemTraThongTinNhap()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(comboBox_Diem.Text) ||
                string.IsNullOrWhiteSpace(txtDiem1.Text) ||
                string.IsNullOrWhiteSpace(txtDiem2.Text))
            {
                return false;
            }

            return true; // Trả về true nếu tất cả các TextBox đều không rỗng

        }

        public void btnSua_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_Diem.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView_Diem.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_Diem.Rows[rowIndex];

                if (selectedRow.Cells["MaMH"].Value == DBNull.Value && selectedRow.Cells["MaSV"].Value == DBNull.Value)
                {
                    MessageBox.Show("Không thể sửa thông tin vì không có mã sinh viên hoặc mã môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string maSV = txtMaSV.Text;
                string maMH = comboBox_Diem.Text;
                float diem1, diem2;

                // Kiểm tra và chuyển đổi giá trị từ TextBox sang kiểu float
                if (!float.TryParse(txtDiem1.Text, out diem1) || !float.TryParse(txtDiem2.Text, out diem2))
                {
                    MessageBox.Show("Điểm nhập vào không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (KiemTraThongTinNhap())
                {
                    if (float.TryParse(txtDiem1.Text.Replace(".", ","), out diem1) && float.TryParse(txtDiem2.Text.Replace(".", ","), out diem2))
                    {
                        if (!diem_DB.KiemTraTonTaiMaSV(maSV))
                        {
                            MessageBox.Show("Mã sinh viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (!diem_DB.KiemTraTonTaiMaMH(maMH))
                        {
                            MessageBox.Show("Mã môn học không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (diem_DB.suaThongTinDiem(maSV, maMH, diem1, diem2))
                        {
                            dataGridView_Diem.DataSource = diem_DB.LayDanhSachDiem();
                            MessageBox.Show("Sửa thông tin điẻm sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sửa thông tin điểm sinh viên không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Điểm nhập vào không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int rowIndex = dataGridView_Diem.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView_Diem.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_Diem.Rows[rowIndex];

                if (selectedRow.Cells["MaMH"].Value == DBNull.Value)
                {
                    MessageBox.Show("Không thể xóa điểm không có mã sinh viên hoặc mã môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maSV = int.Parse( selectedRow.Cells["MaSV"].Value.ToString());

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa điểm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (diem_DB.xoaDiem(maSV))
                    {
                        dataGridView_Diem.DataSource = diem_DB.LayDanhSachDiem();
                        MessageBox.Show("Xóa điểm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa điểm không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim();

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                DataTable searchResult = diem_DB.TimKiemDiem(tuKhoa);

                if (searchResult.Rows.Count > 0)
                {
                    dataGridView_Diem.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("Không có điểm nào được tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_Diem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < dataGridView_Diem.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_Diem.Rows[rowIndex];

                string maSV = selectedRow.Cells["MaSV"].Value.ToString();
                string maMH = selectedRow.Cells["MaMH"].Value.ToString();
                string diem1 = selectedRow.Cells["Diem1"].Value.ToString();
                string diem2 = selectedRow.Cells["Diem2"].Value.ToString();

                if (!string.IsNullOrWhiteSpace(maSV) &&
                    !string.IsNullOrWhiteSpace(maMH) &&
                    !string.IsNullOrWhiteSpace(diem1) &&
                    !string.IsNullOrWhiteSpace(diem2))
                {
                    txtMaSV.Text = maSV;
                    comboBox_Diem.Text = maMH;
                    txtDiem1.Text = diem1;
                    txtDiem2.Text = diem2;
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = string.Empty;
            comboBox_Diem.Text = string.Empty;
            txtDiem1.Text = string.Empty;
            txtDiem2.Text = string.Empty;
        }
    }
}
