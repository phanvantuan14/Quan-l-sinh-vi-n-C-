using QuanLiSinhVien.Views.form_SINHVIEN;
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
    public partial class form_SINHVIEN : Form
    {
        public string Uid { get; set; }
        public string Pass { get; set; }

        public form_SINHVIEN()
        {
            InitializeComponent();

        }
        public form_SINHVIEN(string uid, string pass)
        {
            InitializeComponent();
            this.Uid = uid;
            this.Pass = pass;
        }

        private void form_SINHVIEN_Load(object sender, EventArgs e)
        {
           
        }

        private void panelSinhVien_Click(object sender, EventArgs e)
        {
         
            TT_SinhVien f_sinhVien = new TT_SinhVien(Uid, Pass);
            f_sinhVien.Show();
            f_sinhVien.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void panelMonHoc_Click(object sender, EventArgs e)
        {
            MonDangKi f_giangVien = new MonDangKi();
            f_giangVien.Show();
            f_giangVien.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void panelDiem_Click(object sender, EventArgs e)
        {
            DiemSV f_diem = new DiemSV();
            f_diem.Show();
            f_diem.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void panelHoatDong_Click(object sender, EventArgs e)
        {
            HoatDongSV f_hoatDong = new HoatDongSV();
            f_hoatDong.Show();
            f_hoatDong.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void panelThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            ThoiKhoaBieu f_TKB = new ThoiKhoaBieu();
            f_TKB.Show();
            f_TKB.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void panelBaiTap_Click(object sender, EventArgs e)
        {
            BaiTap f_baiTap = new BaiTap();
            f_baiTap.Show();
            f_baiTap.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        
    }
}
