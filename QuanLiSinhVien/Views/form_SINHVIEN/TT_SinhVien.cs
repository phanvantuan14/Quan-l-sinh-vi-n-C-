using QuanLiSinhVien.Model.sinhvien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien.Views.form_SINHVIEN
{
    public partial class TT_SinhVien : Form
    {
        TT_SINHVIEN_DB sinhvien_db = new TT_SINHVIEN_DB();

        public string Pass { get; set; }
        public string Uid { get; set; }

        public TT_SinhVien()
        {
            InitializeComponent();
           
        }
        public TT_SinhVien(string uid, string pass)
        {
            InitializeComponent();
            Uid = uid;
            Pass = pass;
        }

        private void TT_SINHVIEN_Load(object sender, EventArgs e)
        {
            LayTTSV();
        }

        public void LayTTSV()
        {
            DataTable dt = sinhvien_db.LayDanhSachTTSinhVien(Uid, Pass);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Lấy dòng đầu tiên trong DataTable

                lbMa.Text = row["MaSV"].ToString();
                lbTen.Text = row["HoTen"].ToString();
                lbNgaySinh.Text = row["NgaySinh"].ToString();
                lbGioiTinh.Text = row["GioiTinh"].ToString();
                lbSDT.Text = row["SDT"].ToString();
                lbDiaChi.Text = row["DiaChi"].ToString();
                lbLop.Text = row["TenLop"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin sinh viên.");
            }
        }
    }
}

