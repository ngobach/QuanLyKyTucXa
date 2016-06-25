namespace LapTrinhCSharp.Forms
{
    partial class FormTimKiemSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTimKiemSV));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFHoTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radExcact = new System.Windows.Forms.RadioButton();
            this.radPartialy = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.txtFHoTen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 45);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(249, 17);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(95, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "&Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFHoTen
            // 
            this.txtFHoTen.Location = new System.Drawing.Point(55, 19);
            this.txtFHoTen.Name = "txtFHoTen";
            this.txtFHoTen.Size = new System.Drawing.Size(188, 20);
            this.txtFHoTen.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Họ Tên";
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToResizeColumns = false;
            this.gridView.AllowUserToResizeRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.QueQuan,
            this.SoDienThoai,
            this.MaKhoa,
            this.Khoa,
            this.MaLop,
            this.Lop});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.Location = new System.Drawing.Point(7, 63);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersVisible = false;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(734, 240);
            this.gridView.TabIndex = 1;
            this.gridView.SelectionChanged += new System.EventHandler(this.gridView_SelectionChanged);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.FillWeight = 150F;
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.FillWeight = 200F;
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.FillWeight = 150F;
            this.QueQuan.HeaderText = "Quê Quán";
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "SĐT";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "MaKhoa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            this.MaKhoa.Visible = false;
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "Khoa";
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            this.MaLop.Visible = false;
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "Lop";
            this.Lop.FillWeight = 150F;
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            this.Lop.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGioiTinh);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Controls.Add(this.txtKhoa);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin SV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lớp";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(80, 94);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.ReadOnly = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(244, 20);
            this.txtGioiTinh.TabIndex = 4;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(81, 69);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.ReadOnly = true;
            this.txtQueQuan.Size = new System.Drawing.Size(244, 20);
            this.txtQueQuan.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "SDT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khoa";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(436, 41);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.ReadOnly = true;
            this.txtNgaySinh.Size = new System.Drawing.Size(244, 20);
            this.txtNgaySinh.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(81, 45);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(244, 20);
            this.txtHoTen.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(436, 94);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(244, 20);
            this.txtLop.TabIndex = 6;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(436, 70);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.ReadOnly = true;
            this.txtKhoa.Size = new System.Drawing.Size(244, 20);
            this.txtKhoa.TabIndex = 5;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(436, 13);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(244, 20);
            this.txtSDT.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(81, 17);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(244, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.radPartialy);
            this.groupBox3.Controls.Add(this.radExcact);
            this.groupBox3.Location = new System.Drawing.Point(367, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 45);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tùy chọn";
            // 
            // radExcact
            // 
            this.radExcact.AutoSize = true;
            this.radExcact.Location = new System.Drawing.Point(7, 20);
            this.radExcact.Name = "radExcact";
            this.radExcact.Size = new System.Drawing.Size(93, 17);
            this.radExcact.TabIndex = 0;
            this.radExcact.Text = "Tìm chính xác";
            this.radExcact.UseVisualStyleBackColor = true;
            // 
            // radPartialy
            // 
            this.radPartialy.AutoSize = true;
            this.radPartialy.Checked = true;
            this.radPartialy.Location = new System.Drawing.Point(106, 20);
            this.radPartialy.Name = "radPartialy";
            this.radPartialy.Size = new System.Drawing.Size(89, 17);
            this.radPartialy.TabIndex = 0;
            this.radPartialy.TabStop = true;
            this.radPartialy.Text = "Tìm một phần";
            this.radPartialy.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Giải thích";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTimKiemSV
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 435);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTimKiemSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm sinh viên";
            this.Load += new System.EventHandler(this.FormTimKiemSV_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFHoTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radExcact;
        private System.Windows.Forms.RadioButton radPartialy;
        private System.Windows.Forms.Button button1;
    }
}