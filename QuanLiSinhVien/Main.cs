
//Segoe UI

using QuanLiGiangVien;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panelSinhVien_Click(object sender, EventArgs e)
        {
            SinhVien f_sinhVien = new SinhVien();
            f_sinhVien.Show();
            f_sinhVien.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void panelGiangVien_Click(object sender, EventArgs e)
        {
            GiangVien f_giangVien = new GiangVien();
            f_giangVien.Show();
            f_giangVien.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void panelKhoa_Click(object sender, EventArgs e)
        {
            Khoa f_khoa = new Khoa();
            f_khoa.Show();
            f_khoa.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void panelLop_Click(object sender, EventArgs e)
        {
            Lop f_lop = new Lop();
            f_lop.Show();
            f_lop.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void panelThongKe_Click(object sender, EventArgs e)
        {
            ThongKe f_thongKe = new ThongKe();
            f_thongKe.Show();
            f_thongKe.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void panelHoatDong_Click(object sender, EventArgs e)
        {
            HoatDong f_hoatDong = new HoatDong();
            f_hoatDong.Show();
            f_hoatDong.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void panelDiem_Click(object sender, EventArgs e)
        {
            Diem f_diem = new Diem();
            f_diem.Show();
            f_diem.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void panelMonHoc_Click(object sender, EventArgs e)
        {
            MonHoc f_monHoc = new MonHoc();
            f_monHoc.Show();
            f_monHoc.FormClosed += (s, args) => this.Show();
            this.Hide();
        }
    }
}
