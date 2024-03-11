using QuanLiSinhVien.Views.form_GIANGVIEN;
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
    public partial class form_GIANGVIEN : Form
    {
        public string Pass { get;  set; }
        public string Uid { get;  set; }

        public form_GIANGVIEN()
        {
            InitializeComponent();
        }
        public form_GIANGVIEN(string uid, string pass)
        {
            InitializeComponent();
            this.Uid = uid;
            this.Pass = pass;
        }

        private void panelGiangVien_Click(object sender, EventArgs e)
        {
            TT_GiangVien f_giangVien = new TT_GiangVien(Uid, Pass);
            f_giangVien.Show();
            f_giangVien.FormClosed += (s, args) => this.Show();
            this.Hide();
        }
    }
}
