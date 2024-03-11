
namespace QuanLiSinhVien
{
    partial class Diem
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
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dataGridView_Diem = new System.Windows.Forms.DataGridView();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiem1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiem2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Diem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Diem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaSV.Location = new System.Drawing.Point(101, 79);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(180, 29);
            this.txtMaSV.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(10, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 21);
            this.label8.TabIndex = 82;
            this.label8.Text = "Mã SV";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Fuchsia;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTimKiem.Location = new System.Drawing.Point(789, 432);
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
            this.btnXoa.Location = new System.Drawing.Point(300, 432);
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
            this.btnSua.Location = new System.Drawing.Point(101, 432);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 39);
            this.btnSua.TabIndex = 79;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dataGridView_Diem
            // 
            this.dataGridView_Diem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Diem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Diem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Diem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Diem.Location = new System.Drawing.Point(300, 79);
            this.dataGridView_Diem.Name = "dataGridView_Diem";
            this.dataGridView_Diem.Size = new System.Drawing.Size(614, 328);
            this.dataGridView_Diem.TabIndex = 78;
            this.dataGridView_Diem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Diem_CellClick);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTuKhoa.Location = new System.Drawing.Point(632, 438);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(152, 29);
            this.txtTuKhoa.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(551, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 76;
            this.label6.Text = "Tìm Kiếm";
            // 
            // txtDiem1
            // 
            this.txtDiem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiem1.Location = new System.Drawing.Point(101, 183);
            this.txtDiem1.Name = "txtDiem1";
            this.txtDiem1.Size = new System.Drawing.Size(180, 29);
            this.txtDiem1.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(10, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 74;
            this.label7.Text = "Điểm Kì 1";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThem.Location = new System.Drawing.Point(101, 368);
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
            this.panel1.Location = new System.Drawing.Point(14, 20);
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
            this.label1.Size = new System.Drawing.Size(224, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ ĐIỂM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDiem2
            // 
            this.txtDiem2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiem2.Location = new System.Drawing.Point(101, 235);
            this.txtDiem2.Name = "txtDiem2";
            this.txtDiem2.Size = new System.Drawing.Size(180, 29);
            this.txtDiem2.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(10, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 84;
            this.label3.Text = "Điểm Kì 2";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = global::QuanLiSinhVien.Properties.Resources.lammoi;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLamMoi.Location = new System.Drawing.Point(14, 368);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(53, 39);
            this.btnLamMoi.TabIndex = 86;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(10, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 87;
            this.label4.Text = "Mã MH";
            // 
            // comboBox_Diem
            // 
            this.comboBox_Diem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox_Diem.FormattingEnabled = true;
            this.comboBox_Diem.Location = new System.Drawing.Point(101, 131);
            this.comboBox_Diem.Name = "comboBox_Diem";
            this.comboBox_Diem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Diem.Size = new System.Drawing.Size(180, 29);
            this.comboBox_Diem.TabIndex = 88;
            // 
            // Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(924, 501);
            this.Controls.Add(this.comboBox_Diem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtDiem2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dataGridView_Diem);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiem1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel1);
            this.Name = "Diem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diem";
            this.Load += new System.EventHandler(this.Diem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Diem)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtMaSV;
        public System.Windows.Forms.DataGridView dataGridView_Diem;
        public System.Windows.Forms.TextBox txtTuKhoa;
        public System.Windows.Forms.TextBox txtDiem1;
        public System.Windows.Forms.TextBox txtDiem2;
        public System.Windows.Forms.ComboBox comboBox_Diem;
    }
}