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
    public partial class HoatDong : Form
    {
        HOATDONG_DB hd_DB = new HOATDONG_DB();
        LOP_DB lop_DB = new LOP_DB();
  
        public HoatDong()
        {
            InitializeComponent();
        }

        private void HoatDong_Load(object sender, EventArgs e)
        {
            comboBox_MaLop.DataSource = lop_DB.LayDanhSachLop();
            comboBox_MaLop.DisplayMember = "label";
            comboBox_MaLop.ValueMember = "MaLop";


            dataGridView_HD.DataSource = hd_DB.LayDanhSachHoatDong();

            dataGridView_HD.Columns["ID"].HeaderText = "ID";
            dataGridView_HD.Columns["TenHD"].HeaderText = "Tên Hoạt Động";
            dataGridView_HD.Columns["NgayBD"].HeaderText = "Ngày Bắt Đầu";
            dataGridView_HD.Columns["NgayKT"].HeaderText = "Ngày Kết Thúc";
            dataGridView_HD.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridView_HD.Columns["MaLop"].HeaderText = "Mã Lớp";
            dataGridView_HD.Columns["TenLop"].HeaderText = "Tên Lớp";
        
        }

        private void dataGridView_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < dataGridView_HD.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_HD.Rows[rowIndex];
                if (selectedRow.Cells["TenHD"].Value == DBNull.Value ||
                     selectedRow.Cells["NgayBD"].Value == DBNull.Value ||
                     selectedRow.Cells["NgayKT"].Value == DBNull.Value ||
                     selectedRow.Cells["MaLop"].Value == DBNull.Value ||
                     selectedRow.Cells["DiaChi"].Value == DBNull.Value)
                {
                    return;
                }
                txtTenHD.Text = selectedRow.Cells["TenHD"].Value.ToString();
                dateTimeP_BD.Value = Convert.ToDateTime(selectedRow.Cells["NgayBD"].Value);
                dateTimeP_KT.Value = Convert.ToDateTime(selectedRow.Cells["NgayKT"].Value);
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();

                comboBox_MaLop.Text = selectedRow.Cells["MaLop"].Value.ToString();
            }
        }

        public void btnThem_Click(object sender, EventArgs e)
        {
            string tenHD = txtTenHD.Text;
            DateTime ngayBD = dateTimeP_BD.Value;
            DateTime ngayKT = dateTimeP_KT.Value;
            string diachi = txtDiaChi.Text;
            string malop = comboBox_MaLop.Text;

          

            if (KiemTraThongTinNhap())
            {
                if (hd_DB.KiemTraTonTaiHoatDong(tenHD, ngayBD, ngayKT, diachi, malop))
                {
                    MessageBox.Show("Hoạt động đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (!hd_DB.KiemTraTonTaiMalop(malop))
                    {
                        MessageBox.Show("Mã lớp không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (hd_DB.themHoatDong(tenHD, ngayBD, ngayKT, diachi, malop))
                    {
                        dataGridView_HD.DataSource = hd_DB.LayDanhSachHoatDong();
                        MessageBox.Show("Hoạt động thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrWhiteSpace(txtTenHD.Text) ||
                dateTimeP_BD.Value == dateTimeP_BD.MinDate||
                dateTimeP_KT.Value == dateTimeP_KT.MinDate||
               
                string.IsNullOrWhiteSpace(comboBox_MaLop.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                return false;
            }

            return true; // Trả về true nếu tất cả các TextBox đều không rỗng

        }

        public void btnSua_Click(object sender, EventArgs e)
        {

            int rowIndex = dataGridView_HD.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView_HD.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_HD.Rows[rowIndex];

                if (selectedRow.Cells["id"].Value == DBNull.Value)
                {
                    MessageBox.Show("Không thể sửa thông tin vì không có mã hoạt động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maHD;
                if (!int.TryParse(selectedRow.Cells["id"].Value.ToString(), out maHD))
                {
                    MessageBox.Show("Không thể sửa thông tin vì hoạt động không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenHD = txtTenHD.Text;
                DateTime ngayBD = dateTimeP_BD.Value;
                DateTime ngayKT = dateTimeP_KT.Value;
                string diachi = txtDiaChi.Text;
                string malop = comboBox_MaLop.Text;

                if (KiemTraThongTinNhap())
                {
                    if (hd_DB.KiemTraTonTaiHoatDong(tenHD, ngayBD, ngayKT, diachi, malop))
                    {
                        MessageBox.Show("Hoạt động đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (!hd_DB.KiemTraTonTaiMalop(malop))
                        {
                            MessageBox.Show("Mã lớp không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (hd_DB.suaThongTinHoatDong(tenHD, ngayBD, ngayKT, diachi, malop, maHD))
                        {
                            dataGridView_HD.DataSource = hd_DB.LayDanhSachHoatDong();
                            MessageBox.Show("Sửa thông tin hoạt động thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sửa thông tin hoạt động không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            int rowIndex = dataGridView_HD.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView_HD.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_HD.Rows[rowIndex];

                if (selectedRow.Cells["id"].Value == DBNull.Value)
                {
                    MessageBox.Show("Không thể xóa hoạt động vì không có mã hoạt động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maHD;
                if (!int.TryParse(selectedRow.Cells["id"].Value.ToString(), out maHD))
                {
                    MessageBox.Show("Không thể xóa hoạt động vì mã hoạt động không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa hoạt động này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (hd_DB.xoaHoatDong(maHD))
                    {
                        dataGridView_HD.DataSource = hd_DB.LayDanhSachHoatDong();
                        MessageBox.Show("Xóa hoạt động thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa hoạt động không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim();

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                DataTable searchResult = hd_DB.TimKiemHoatDong(tuKhoa);

                if (searchResult.Rows.Count > 0)
                {
                    dataGridView_HD.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("Không có hoạt động nào được tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenHD.Text = string.Empty;
            dateTimeP_BD.Value = DateTime.Now;
            dateTimeP_KT.Value = DateTime.Now;
            txtDiaChi.Text = string.Empty;
            comboBox_MaLop.Text = string.Empty;
          
        }

        
    }
}
