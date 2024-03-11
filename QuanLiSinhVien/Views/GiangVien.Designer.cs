
namespace QuanLiGiangVien
{
    partial class GiangVien
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
            this.groupBox_GioiTinh = new System.Windows.Forms.GroupBox();
            this.radioB_Nu = new System.Windows.Forms.RadioButton();
            this.radioB_Nam = new System.Windows.Forms.RadioButton();
            this.dateTimeP_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_MaKhoa = new System.Windows.Forms.ComboBox();
            this.comboBox__MaMH = new System.Windows.Forms.ComboBox();
            this.dataGridView_GiangVien = new System.Windows.Forms.DataGridView();
            this.groupBox_GioiTinh.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_GioiTinh
            // 
            this.groupBox_GioiTinh.Controls.Add(this.radioB_Nu);
            this.groupBox_GioiTinh.Controls.Add(this.radioB_Nam);
            this.groupBox_GioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox_GioiTinh.Location = new System.Drawing.Point(99, 158);
            this.groupBox_GioiTinh.Name = "groupBox_GioiTinh";
            this.groupBox_GioiTinh.Size = new System.Drawing.Size(180, 44);
            this.groupBox_GioiTinh.TabIndex = 69;
            this.groupBox_GioiTinh.TabStop = false;
            // 
            // radioB_Nu
            // 
            this.radioB_Nu.AutoSize = true;
            this.radioB_Nu.Location = new System.Drawing.Point(112, 13);
            this.radioB_Nu.Name = "radioB_Nu";
            this.radioB_Nu.Size = new System.Drawing.Size(53, 25);
            this.radioB_Nu.TabIndex = 1;
            this.radioB_Nu.TabStop = true;
            this.radioB_Nu.Text = "Nữ ";
            this.radioB_Nu.UseVisualStyleBackColor = true;
            // 
            // radioB_Nam
            // 
            this.radioB_Nam.AutoSize = true;
            this.radioB_Nam.Location = new System.Drawing.Point(16, 13);
            this.radioB_Nam.Name = "radioB_Nam";
            this.radioB_Nam.Size = new System.Drawing.Size(62, 25);
            this.radioB_Nam.TabIndex = 0;
            this.radioB_Nam.TabStop = true;
            this.radioB_Nam.Text = "Nam";
            this.radioB_Nam.UseVisualStyleBackColor = true;
            // 
            // dateTimeP_NgaySinh
            // 
            this.dateTimeP_NgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimeP_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeP_NgaySinh.Location = new System.Drawing.Point(99, 123);
            this.dateTimeP_NgaySinh.Name = "dateTimeP_NgaySinh";
            this.dateTimeP_NgaySinh.Size = new System.Drawing.Size(180, 29);
            this.dateTimeP_NgaySinh.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(8, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 66;
            this.label8.Text = "Mã Khoa";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Fuchsia;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTimKiem.Location = new System.Drawing.Point(789, 429);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 39);
            this.btnTimKiem.TabIndex = 65;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(298, 431);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 39);
            this.btnXoa.TabIndex = 64;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Yellow;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSua.Location = new System.Drawing.Point(99, 431);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 39);
            this.btnSua.TabIndex = 63;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(8, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 55;
            this.label5.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(8, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 54;
            this.label3.Text = "Ngày Sinh";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTuKhoa.Location = new System.Drawing.Point(631, 435);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(152, 29);
            this.txtTuKhoa.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(549, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 60;
            this.label6.Text = "Tìm Kiếm";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiaChi.Location = new System.Drawing.Point(99, 274);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(180, 29);
            this.txtDiaChi.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(8, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 58;
            this.label7.Text = "Địa Chỉ";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSDT.Location = new System.Drawing.Point(99, 224);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(180, 29);
            this.txtSDT.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(8, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 56;
            this.label4.Text = "SDT";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHoTen.Location = new System.Drawing.Point(99, 78);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(180, 29);
            this.txtHoTen.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 52;
            this.label2.Text = "Họ Tên";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThem.Location = new System.Drawing.Point(99, 367);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 39);
            this.btnThem.TabIndex = 51;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.label1.Size = new System.Drawing.Size(319, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ GIẢNG VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 40);
            this.panel1.TabIndex = 50;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = global::QuanLiSinhVien.Properties.Resources.lammoi;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLamMoi.Location = new System.Drawing.Point(12, 367);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(53, 39);
            this.btnLamMoi.TabIndex = 70;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(153, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 71;
            this.label9.Text = "Mã MH";
            // 
            // comboBox_MaKhoa
            // 
            this.comboBox_MaKhoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox_MaKhoa.FormattingEnabled = true;
            this.comboBox_MaKhoa.Location = new System.Drawing.Point(77, 320);
            this.comboBox_MaKhoa.Name = "comboBox_MaKhoa";
            this.comboBox_MaKhoa.Size = new System.Drawing.Size(70, 29);
            this.comboBox_MaKhoa.TabIndex = 72;
            // 
            // comboBox__MaMH
            // 
            this.comboBox__MaMH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox__MaMH.FormattingEnabled = true;
            this.comboBox__MaMH.Location = new System.Drawing.Point(211, 320);
            this.comboBox__MaMH.Name = "comboBox__MaMH";
            this.comboBox__MaMH.Size = new System.Drawing.Size(70, 29);
            this.comboBox__MaMH.TabIndex = 73;
            // 
            // dataGridView_GiangVien
            // 
            this.dataGridView_GiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_GiangVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_GiangVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_GiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_GiangVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_GiangVien.Location = new System.Drawing.Point(298, 81);
            this.dataGridView_GiangVien.Name = "dataGridView_GiangVien";
            this.dataGridView_GiangVien.Size = new System.Drawing.Size(614, 328);
            this.dataGridView_GiangVien.TabIndex = 74;
            this.dataGridView_GiangVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_GiangVien_CellClick_1);
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(924, 501);
            this.Controls.Add(this.dataGridView_GiangVien);
            this.Controls.Add(this.comboBox__MaMH);
            this.Controls.Add(this.comboBox_MaKhoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.groupBox_GioiTinh);
            this.Controls.Add(this.dateTimeP_NgaySinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel1);
            this.Name = "GiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiangVien";
            this.Load += new System.EventHandler(this.GiangVien_Load);
            this.groupBox_GioiTinh.ResumeLayout(false);
            this.groupBox_GioiTinh.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_GioiTinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.RadioButton radioB_Nu;
        public System.Windows.Forms.RadioButton radioB_Nam;
        public System.Windows.Forms.DateTimePicker dateTimeP_NgaySinh;
        public System.Windows.Forms.TextBox txtDiaChi;
        public System.Windows.Forms.TextBox txtSDT;
        public System.Windows.Forms.TextBox txtHoTen;
        public System.Windows.Forms.ComboBox comboBox_MaKhoa;
        public System.Windows.Forms.ComboBox comboBox__MaMH;
        public System.Windows.Forms.TextBox txtTuKhoa;
        public System.Windows.Forms.DataGridView dataGridView_GiangVien;
    }
}