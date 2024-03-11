
namespace QuanLiSinhVien
{
    partial class MonHoc
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
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dataGridView_MH = new System.Windows.Forms.DataGridView();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTinChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MH)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaMH
            // 
            this.txtMaMH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaMH.Location = new System.Drawing.Point(99, 180);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(180, 29);
            this.txtMaMH.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(8, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 82;
            this.label8.Text = "Mã MH";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Fuchsia;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTimKiem.Location = new System.Drawing.Point(789, 427);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 39);
            this.btnTimKiem.TabIndex = 81;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(298, 429);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 39);
            this.btnXoa.TabIndex = 80;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Yellow;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSua.Location = new System.Drawing.Point(99, 429);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 39);
            this.btnSua.TabIndex = 79;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dataGridView_MH
            // 
            this.dataGridView_MH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_MH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_MH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_MH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_MH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_MH.Location = new System.Drawing.Point(298, 76);
            this.dataGridView_MH.Name = "dataGridView_MH";
            this.dataGridView_MH.Size = new System.Drawing.Size(614, 328);
            this.dataGridView_MH.TabIndex = 78;
            this.dataGridView_MH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_MH_CellClick);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTuKhoa.Location = new System.Drawing.Point(631, 433);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(152, 29);
            this.txtTuKhoa.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(549, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 76;
            this.label6.Text = "Tìm Kiếm";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenMH.Location = new System.Drawing.Point(99, 229);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(180, 29);
            this.txtTenMH.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(8, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tên MH";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThem.Location = new System.Drawing.Point(99, 365);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 39);
            this.btnThem.TabIndex = 69;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 40);
            this.panel1.TabIndex = 68;
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
            this.label1.Size = new System.Drawing.Size(294, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ MÔN HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = global::QuanLiSinhVien.Properties.Resources.lammoi;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLamMoi.Location = new System.Drawing.Point(12, 365);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(53, 39);
            this.btnLamMoi.TabIndex = 84;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtTinChi
            // 
            this.txtTinChi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTinChi.Location = new System.Drawing.Point(99, 279);
            this.txtTinChi.Name = "txtTinChi";
            this.txtTinChi.Size = new System.Drawing.Size(180, 29);
            this.txtTinChi.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(8, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 85;
            this.label3.Text = "Số Tín Chỉ";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaSV.Location = new System.Drawing.Point(99, 76);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(180, 29);
            this.txtMaSV.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(8, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 87;
            this.label4.Text = "Mã SV";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaGV.Location = new System.Drawing.Point(99, 127);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(180, 29);
            this.txtMaGV.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(8, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 89;
            this.label5.Text = "Mã GV";
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(924, 501);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTinChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dataGridView_MH);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel1);
            this.Name = "MonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonHoc";
            this.Load += new System.EventHandler(this.MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMaMH;
        public System.Windows.Forms.DataGridView dataGridView_MH;
        public System.Windows.Forms.TextBox txtTuKhoa;
        public System.Windows.Forms.TextBox txtTenMH;
        public System.Windows.Forms.TextBox txtTinChi;
        public System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label5;
    }
}