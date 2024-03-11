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

namespace QuanLiGiangVien
{
    public partial class GiangVien : Form
    {
        GIANGVIEN_DB gv_DB = new GIANGVIEN_DB();
        KHOA_DB khoa_DB = new KHOA_DB();
        MONHOC_DB monhoc_DB = new MONHOC_DB();
        public GiangVien()
        {
            InitializeComponent();
        }

        private void GiangVien_Load(object sender, EventArgs e)
        {
            comboBox__MaMH.DataSource = monhoc_DB.LayDanhSachMH();
            comboBox__MaMH.DisplayMember = "label";
            comboBox__MaMH.ValueMember = "MaMH";

            comboBox_MaKhoa.DataSource = khoa_DB.LayDanhSachKhoa();
            comboBox_MaKhoa.DisplayMember = "label";
            comboBox_MaKhoa.ValueMember = "MaKhoa";

            dataGridView_GiangVien.DataSource = gv_DB.LayDanhSachGiangVien();

            dataGridView_GiangVien.Columns["ID"].HeaderText = "ID";
            dataGridView_GiangVien.Columns["HoTen"].HeaderText = "Họ Tên";
            dataGridView_GiangVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridView_GiangVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dataGridView_GiangVien.Columns["SDT"].HeaderText = "SDT";
            dataGridView_GiangVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridView_GiangVien.Columns["MaKhoa"].HeaderText = "Mã Khoa";
            dataGridView_GiangVien.Columns["TenKhoa"].HeaderText = "Tên Khoa";
            dataGridView_GiangVien.Columns["MaMH"].HeaderText = "Mã MH";
            dataGridView_GiangVien.Columns["TenMH"].HeaderText = "Tên MH";

        }

        public void btnThem_Click(object sender, EventArgs e)
        {
            string hote = txtHoTen.Text;
            DateTime ngaysinh = dateTimeP_NgaySinh.Value;
            string gioitinh = "Nam";
            string SDT = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            string makhoa = comboBox_MaKhoa.Text;
            string mamh = comboBox__MaMH.Text;
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
                    if (gv_DB.KiemTraTonTaiGiangVien(hote, ngaysinh, gioitinh, SDT, diachi, makhoa,mamh))
                    {
                        MessageBox.Show("Giảng viên đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (!gv_DB.KiemTraTonTaiMaKhoa(makhoa))
                        {
                            MessageBox.Show("Mã lớp không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (!gv_DB.KiemTraTonTaiMaMH(mamh))
                        {
                            MessageBox.Show("Mã lớp không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (gv_DB.themGiangVien(hote, ngaysinh, gioitinh, SDT, diachi, makhoa, mamh))
                        {
                            dataGridView_GiangVien.DataSource = gv_DB.LayDanhSachGiangVien();
                            MessageBox.Show("Thêm giảng viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string.IsNullOrWhiteSpace(comboBox_MaKhoa.Text) ||
                string.IsNullOrWhiteSpace(comboBox__MaMH.Text) ||
                dateTimeP_NgaySinh.Value == dateTimeP_NgaySinh.MinDate ||
                !radioB_Nam.Checked && !radioB_Nu.Checked)
            {
                return false;
            }

            return true; // Trả về true nếu tất cả các TextBox đều không rỗng

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = string.Empty;
            dateTimeP_NgaySinh.Value = DateTime.Now;
            radioB_Nam.Checked = true;
            radioB_Nu.Checked = false;
            txtSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            comboBox_MaKhoa.Text = string.Empty;
            comboBox__MaMH.Text = string.Empty;
        }

        public void btnSua_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_GiangVien.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView_GiangVien.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_GiangVien.Rows[rowIndex];

                if (selectedRow.Cells["ID"].Value == DBNull.Value)
                {
                    MessageBox.Show("Không thể sửa thông tin vì không có mã giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int magv;
                if (!int.TryParse(selectedRow.Cells["ID"].Value.ToString(), out magv))
                {
                    MessageBox.Show("Không thể sửa thông tin vì mã giảng viên không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hote = txtHoTen.Text;
                DateTime ngaysinh = dateTimeP_NgaySinh.Value;
                string gioitinh = radioB_Nam.Checked ? "Nam" : "Nữ";
                string SDT = txtSDT.Text;
                string diachi = txtDiaChi.Text;
                string makhoa = comboBox_MaKhoa.Text;
                string mamh = comboBox__MaMH.Text;

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
                        if (gv_DB.KiemTraTonTaiGiangVien(hote, ngaysinh, gioitinh, SDT, diachi, makhoa, mamh))
                        {
                            MessageBox.Show("Giảng viên đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (!gv_DB.KiemTraTonTaiMaKhoa(makhoa))
                            {
                                MessageBox.Show("Mã lớp không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (!gv_DB.KiemTraTonTaiMaMH(mamh))
                            {
                                MessageBox.Show("Mã lớp không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (gv_DB.suaThongTinGiangVien(hote, ngaysinh, gioitinh, SDT, diachi, makhoa, mamh, magv))
                            {
                                dataGridView_GiangVien.DataSource = gv_DB.LayDanhSachGiangVien();
                                MessageBox.Show("Sửa thông tin giảng viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Sửa thông tin giảng viên không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            int rowIndex = dataGridView_GiangVien.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView_GiangVien.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_GiangVien.Rows[rowIndex];

                if (selectedRow.Cells["ID"].Value == DBNull.Value)
                {
                    MessageBox.Show("Không thể xóa giảng viên vì không có mã giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maGV;
                if (!int.TryParse(selectedRow.Cells["ID"].Value.ToString(), out maGV))
                {
                    MessageBox.Show("Không thể xóa sinh viên vì mã giảng viên không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (gv_DB.xoaGiangVien(maGV))
                    {
                        dataGridView_GiangVien.DataSource = gv_DB.LayDanhSachGiangVien();
                        MessageBox.Show("Xóa giảng viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa giảng viên không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim();

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                DataTable searchResult = gv_DB.TimKiemGiangVien(tuKhoa);

                if (searchResult.Rows.Count > 0)
                {
                    dataGridView_GiangVien.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("Không có giảng viên nào được tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_GiangVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < dataGridView_GiangVien.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_GiangVien.Rows[rowIndex];
                if (selectedRow.Cells["HoTen"].Value == DBNull.Value ||
                     selectedRow.Cells["NgaySinh"].Value == DBNull.Value ||
                     selectedRow.Cells["SDT"].Value == DBNull.Value ||
                     selectedRow.Cells["DiaChi"].Value == DBNull.Value ||
                     selectedRow.Cells["MaKhoa"].Value == DBNull.Value ||
                     selectedRow.Cells["MaMH"].Value == DBNull.Value)
                {
                    return;
                }
                txtHoTen.Text = selectedRow.Cells["HoTen"].Value.ToString();
                dateTimeP_NgaySinh.Value = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value);
                txtSDT.Text = selectedRow.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                comboBox_MaKhoa.Text = selectedRow.Cells["MaKhoa"].Value.ToString();
                comboBox__MaMH.Text = selectedRow.Cells["MaMH"].Value.ToString();

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
    }
}
