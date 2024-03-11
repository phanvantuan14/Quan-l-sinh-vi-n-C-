using QuanLiSinhVien.Model.giangvien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien.Views.form_GIANGVIEN
{
    public partial class TT_GiangVien : Form
    {
        TT_GIANGVIEN_DB giangvien_db = new TT_GIANGVIEN_DB();

        public string Pass { get; set; }
        public string Uid { get; set; }

        public TT_GiangVien()
        {
            InitializeComponent();
        }
        public TT_GiangVien(string uid, string pass)
        {
            InitializeComponent();
            Uid = uid;
            Pass = pass;
        }
        private void TT_GiangVien_Load(object sender, EventArgs e)
        {
            LayTTGV();
        }
        public void LayTTGV()
        {
            DataTable dt = giangvien_db.LayDanhSachTTGiangVien(Uid, Pass);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Lấy dòng đầu tiên trong DataTable

                lbMa.Text = row["ID"].ToString();
                lbTen.Text = row["HoTen"].ToString();
                lbNgaySinh.Text = row["NgaySinh"].ToString();
                lbGioiTinh.Text = row["GioiTinh"].ToString();
                lbSDT.Text = row["SDT"].ToString();
                lbDiaChi.Text = row["DiaChi"].ToString();
                lbKhoa.Text = row["TenKhoa"].ToString();
                lbMonHoc.Text = row["TenMH"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin sinh viên.");
            }
        }

     
    }
}
