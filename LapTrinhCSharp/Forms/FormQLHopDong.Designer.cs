namespace LapTrinhCSharp.Forms
{
    partial class FormQLHopDong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLHopDong));
            this.grid = new System.Windows.Forms.DataGridView();
            this.MaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chk = new System.Windows.Forms.CheckBox();
            this.cmbSV = new System.Windows.Forms.ComboBox();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHopDong,
            this.NgayBatDau,
            this.NgayHetHan,
            this.MaPhong,
            this.TenPhong,
            this.SoNguoi,
            this.DaHetHan,
            this.DaKetThuc});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle14;
            this.grid.Location = new System.Drawing.Point(12, 119);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(687, 340);
            this.grid.TabIndex = 0;
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // MaHopDong
            // 
            this.MaHopDong.DataPropertyName = "MaHopDong";
            this.MaHopDong.HeaderText = "Mã HĐ";
            this.MaHopDong.Name = "MaHopDong";
            this.MaHopDong.ReadOnly = true;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.ReadOnly = true;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày hết hạn";
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.ReadOnly = true;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Ma Phong";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            this.MaPhong.Visible = false;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "Phong";
            this.TenPhong.HeaderText = "Phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            // 
            // SoNguoi
            // 
            this.SoNguoi.DataPropertyName = "SoNguoi";
            this.SoNguoi.HeaderText = "Số người ở";
            this.SoNguoi.Name = "SoNguoi";
            this.SoNguoi.ReadOnly = true;
            // 
            // DaHetHan
            // 
            this.DaHetHan.DataPropertyName = "DaHetHan";
            this.DaHetHan.HeaderText = "Đã hết hạn";
            this.DaHetHan.Name = "DaHetHan";
            this.DaHetHan.ReadOnly = true;
            // 
            // DaKetThuc
            // 
            this.DaKetThuc.DataPropertyName = "DaKetThuc";
            this.DaKetThuc.HeaderText = "Đã kết thúc";
            this.DaKetThuc.Name = "DaKetThuc";
            this.DaKetThuc.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.chk);
            this.groupBox1.Controls.Add(this.cmbSV);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.cmbPhong);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(277, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(26, 21);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chk
            // 
            this.chk.AutoSize = true;
            this.chk.Location = new System.Drawing.Point(510, 75);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(88, 17);
            this.chk.TabIndex = 4;
            this.chk.Text = "Đã kết thúc?";
            this.chk.UseVisualStyleBackColor = true;
            // 
            // cmbSV
            // 
            this.cmbSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSV.FormattingEnabled = true;
            this.cmbSV.Location = new System.Drawing.Point(75, 45);
            this.cmbSV.Name = "cmbSV";
            this.cmbSV.Size = new System.Drawing.Size(196, 21);
            this.cmbSV.TabIndex = 2;
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "dd/MM/yyyy";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(510, 45);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(162, 20);
            this.dtp2.TabIndex = 3;
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "dd/MM/yyyy";
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(510, 19);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(162, 20);
            this.dtp1.TabIndex = 3;
            // 
            // cmbPhong
            // 
            this.cmbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.Location = new System.Drawing.Point(75, 71);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(228, 21);
            this.cmbPhong.TabIndex = 2;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(75, 19);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(228, 20);
            this.txtMaHD.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày hết hạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HĐ";
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Maroon;
            this.btnXoa.Location = new System.Drawing.Point(175, 465);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 105;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(94, 465);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 40);
            this.btnUpdate.TabIndex = 104;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 103;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReport
            // 
            this.btnReport.ForeColor = System.Drawing.Color.Maroon;
            this.btnReport.Location = new System.Drawing.Point(512, 465);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(187, 40);
            this.btnReport.TabIndex = 105;
            this.btnReport.Text = "Báo cáo danh sách hợp đồng";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(466, 465);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(40, 40);
            this.btnPrint.TabIndex = 105;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormQLHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 517);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormQLHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hợp đồng";
            this.Load += new System.EventHandler(this.FormQLHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPhong;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ComboBox cmbSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaKetThuc;
        private System.Windows.Forms.Button btnPrint;
    }
}