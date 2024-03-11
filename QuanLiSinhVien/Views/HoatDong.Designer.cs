
namespace QuanLiSinhVien
{
    partial class HoatDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeP_BD = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dataGridView_HD = new System.Windows.Forms.DataGridView();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dateTimeP_KT = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_MaLop = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 40);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(317, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ HOẠT ĐỘNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimeP_BD
            // 
            this.dateTimeP_BD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimeP_BD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeP_BD.Location = new System.Drawing.Point(99, 117);
            this.dateTimeP_BD.Name = "dateTimeP_BD";
            this.dateTimeP_BD.Size = new System.Drawing.Size(180, 29);
            this.dateTimeP_BD.TabIndex = 84;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Fuchsia;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTimKiem.Location = new System.Drawing.Point(789, 423);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 39);
            this.btnTimKiem.TabIndex = 83;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(298, 425);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 39);
            this.btnXoa.TabIndex = 82;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Yellow;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSua.Location = new System.Drawing.Point(99, 425);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 39);
            this.btnSua.TabIndex = 81;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dataGridView_HD
            // 
            this.dataGridView_HD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_HD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_HD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_HD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_HD.Location = new System.Drawing.Point(298, 72);
            this.dataGridView_HD.Name = "dataGridView_HD";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_HD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_HD.Size = new System.Drawing.Size(614, 328);
            this.dataGridView_HD.TabIndex = 80;
            this.dataGridView_HD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_HD_CellClick);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTuKhoa.Location = new System.Drawing.Point(631, 429);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(152, 29);
            this.txtTuKhoa.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(549, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 78;
            this.label6.Text = "Tìm Kiếm";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiaChi.Location = new System.Drawing.Point(99, 220);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(180, 29);
            this.txtDiaChi.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(8, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 76;
            this.label7.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(8, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 72;
            this.label3.Text = "Ngày BD";
            // 
            // txtTenHD
            // 
            this.txtTenHD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenHD.Location = new System.Drawing.Point(99, 72);
            this.txtTenHD.Name = "txtTenHD";
            this.txtTenHD.Size = new System.Drawing.Size(180, 29);
            this.txtTenHD.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tên";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThem.Location = new System.Drawing.Point(99, 361);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 39);
            this.btnThem.TabIndex = 69;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dateTimeP_KT
            // 
            this.dateTimeP_KT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimeP_KT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeP_KT.Location = new System.Drawing.Point(99, 167);
            this.dateTimeP_KT.Name = "dateTimeP_KT";
            this.dateTimeP_KT.Size = new System.Drawing.Size(180, 29);
            this.dateTimeP_KT.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(8, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 85;
            this.label4.Text = "Ngày KT";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = global::QuanLiSinhVien.Properties.Resources.lammoi;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLamMoi.Location = new System.Drawing.Point(12, 361);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(53, 39);
            this.btnLamMoi.TabIndex = 87;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(8, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 90;
            this.label8.Text = "Mã Lớp";
            // 
            // comboBox_MaLop
            // 
            this.comboBox_MaLop.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox_MaLop.FormattingEnabled = true;
            this.comboBox_MaLop.Location = new System.Drawing.Point(99, 272);
            this.comboBox_MaLop.Name = "comboBox_MaLop";
            this.comboBox_MaLop.Size = new System.Drawing.Size(180, 29);
            this.comboBox_MaLop.TabIndex = 92;
            // 
            // HoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(924, 501);
            this.Controls.Add(this.comboBox_MaLop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dateTimeP_KT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeP_BD);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dataGridView_HD);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel1);
            this.Name = "HoatDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoatDong";
            this.Load += new System.EventHandler(this.HoatDong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker dateTimeP_BD;
        public System.Windows.Forms.DataGridView dataGridView_HD;
        public System.Windows.Forms.TextBox txtTuKhoa;
        public System.Windows.Forms.TextBox txtDiaChi;
        public System.Windows.Forms.TextBox txtTenHD;
        public System.Windows.Forms.DateTimePicker dateTimeP_KT;
        public System.Windows.Forms.ComboBox comboBox_MaLop;
    }
}