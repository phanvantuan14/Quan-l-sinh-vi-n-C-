using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 flogin = new Form1();
            if (flogin.ShowDialog() == DialogResult.OK)
            {
                if (flogin.UserRole == "admin")
                {
                    Application.Run(new Main());
                }
                else if (flogin.UserRole == "tk_sinhvien")
                {
                    form_SINHVIEN formSV = new form_SINHVIEN();
                    formSV.Uid = flogin.Uid;
                    formSV.Pass = flogin.Pass;
                    Application.Run(formSV);
                }
                else if (flogin.UserRole == "tk_giangvien")
                {
                    form_GIANGVIEN form_GV = new form_GIANGVIEN();
                    form_GV.Uid = flogin.Uid;
                    form_GV.Pass = flogin.Pass;
                    Application.Run(form_GV);
                }
            }
        }
    }
}
