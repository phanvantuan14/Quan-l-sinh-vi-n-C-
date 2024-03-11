using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QuanLiSinhVien
{
     public partial class Form1 : Form
    {
        public string UserRole { get; private set; }
        public string Pass { get; private set; }
        public string Uid { get; private set; }

        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Uid = txtTaiKhoan.Text;
            Pass = txtMatKhau.Text;

            ConnectMySql db = new ConnectMySql();
            MySqlCommand command = new MySqlCommand(
                "SELECT 'admin' AS role FROM `admin` WHERE `uid` = @uid AND `pass` = @pass " +
                "UNION ALL SELECT 'tk_sinhvien' AS role FROM `tk_sinhvien` WHERE `uid` = @uid AND `pass` = @pass " +
                "UNION ALL SELECT 'tk_giangvien' AS role FROM `tk_giangvien` WHERE `uid` = @uid AND `pass` = @pass",
                db.getConnection());

            command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = Uid;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Pass;

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    UserRole = table.Rows[0]["role"].ToString();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Sai Mật khẩu hoặc Tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}

