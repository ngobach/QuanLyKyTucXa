namespace LapTrinhCSharp
{
    partial class FormQLHoaDon
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
            this.components = new System.ComponentModel.Container();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.dataSet = new LapTrinhCSharp.DataSet();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new LapTrinhCSharp.DataSetTableAdapters.SinhVienTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboMa = new System.Windows.Forms.ComboBox();
            this.txtPhuphi = new System.Windows.Forms.TextBox();
            this.txtTiendien = new System.Windows.Forms.TextBox();
            this.txtTiennuoc = new System.Windows.Forms.TextBox();
            this.txtTienphong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkTT = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdDaTT = new System.Windows.Forms.RadioButton();
            this.rdChuaTT = new System.Windows.Forms.RadioButton();
            this.rdTatca = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiennuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phuphi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dathanhtoan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Chitiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBaocao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaHopDong,
            this.Thang,
            this.Nam,
            this.TienPhong,
            this.Tiennuoc,
            this.TienDien,
            this.Phuphi,
            this.Tongtien,
            this.Dathanhtoan,
            this.Chitiet});
            this.Grid.Location = new System.Drawing.Point(12, 187);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(807, 233);
            this.Grid.TabIndex = 0;
            this.Grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.dataSet;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNam);
            this.groupBox1.Controls.Add(this.txtThang);
            this.groupBox1.Controls.Add(this.comboMa);
            this.groupBox1.Controls.Add(this.txtPhuphi);
            this.groupBox1.Controls.Add(this.txtTiendien);
            this.groupBox1.Controls.Add(this.txtTiennuoc);
            this.groupBox1.Controls.Add(this.txtTienphong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkTT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // comboMa
            // 
            this.comboMa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMa.FormattingEnabled = true;
            this.comboMa.Location = new System.Drawing.Point(83, 22);
            this.comboMa.Name = "comboMa";
            this.comboMa.Size = new System.Drawing.Size(169, 21);
            this.comboMa.TabIndex = 12;
            // 
            // txtPhuphi
            // 
            this.txtPhuphi.Location = new System.Drawing.Point(358, 121);
            this.txtPhuphi.Name = "txtPhuphi";
            this.txtPhuphi.Size = new System.Drawing.Size(146, 20);
            this.txtPhuphi.TabIndex = 11;
            // 
            // txtTiendien
            // 
            this.txtTiendien.Location = new System.Drawing.Point(358, 88);
            this.txtTiendien.Name = "txtTiendien";
            this.txtTiendien.Size = new System.Drawing.Size(146, 20);
            this.txtTiendien.TabIndex = 10;
            // 
            // txtTiennuoc
            // 
            this.txtTiennuoc.Location = new System.Drawing.Point(358, 55);
            this.txtTiennuoc.Name = "txtTiennuoc";
            this.txtTiennuoc.Size = new System.Drawing.Size(146, 20);
            this.txtTiennuoc.TabIndex = 9;
            // 
            // txtTienphong
            // 
            this.txtTienphong.Location = new System.Drawing.Point(358, 22);
            this.txtTienphong.Name = "txtTienphong";
            this.txtTienphong.Size = new System.Drawing.Size(146, 20);
            this.txtTienphong.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phụ phí";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tiền điện";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tiền nước";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tiền phòng";
            // 
            // checkTT
            // 
            this.checkTT.AutoSize = true;
            this.checkTT.Location = new System.Drawing.Point(9, 123);
            this.checkTT.Name = "checkTT";
            this.checkTT.Size = new System.Drawing.Size(94, 17);
            this.checkTT.TabIndex = 3;
            this.checkTT.Text = "Đã thanh toán";
            this.checkTT.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hợp đồng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdDaTT);
            this.groupBox2.Controls.Add(this.rdChuaTT);
            this.groupBox2.Controls.Add(this.rdTatca);
            this.groupBox2.Location = new System.Drawing.Point(562, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 158);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê";
            // 
            // rdDaTT
            // 
            this.rdDaTT.AutoSize = true;
            this.rdDaTT.Location = new System.Drawing.Point(19, 124);
            this.rdDaTT.Name = "rdDaTT";
            this.rdDaTT.Size = new System.Drawing.Size(93, 17);
            this.rdDaTT.TabIndex = 2;
            this.rdDaTT.TabStop = true;
            this.rdDaTT.Text = "Đã thanh toán";
            this.rdDaTT.UseVisualStyleBackColor = true;
            this.rdDaTT.CheckedChanged += new System.EventHandler(this.rdDaTT_CheckedChanged);
            // 
            // rdChuaTT
            // 
            this.rdChuaTT.AutoSize = true;
            this.rdChuaTT.Location = new System.Drawing.Point(19, 72);
            this.rdChuaTT.Name = "rdChuaTT";
            this.rdChuaTT.Size = new System.Drawing.Size(104, 17);
            this.rdChuaTT.TabIndex = 1;
            this.rdChuaTT.TabStop = true;
            this.rdChuaTT.Text = "Chưa thanh toán";
            this.rdChuaTT.UseVisualStyleBackColor = true;
            this.rdChuaTT.CheckedChanged += new System.EventHandler(this.rdChuaTT_CheckedChanged);
            // 
            // rdTatca
            // 
            this.rdTatca.AutoSize = true;
            this.rdTatca.Location = new System.Drawing.Point(19, 25);
            this.rdTatca.Name = "rdTatca";
            this.rdTatca.Size = new System.Drawing.Size(56, 17);
            this.rdTatca.TabIndex = 0;
            this.rdTatca.TabStop = true;
            this.rdTatca.Text = "Tất cả";
            this.rdTatca.UseVisualStyleBackColor = true;
            this.rdTatca.CheckedChanged += new System.EventHandler(this.rdTatca_CheckedChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 444);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 33);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(108, 444);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(90, 33);
            this.btnCapnhat.TabIndex = 4;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(204, 444);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 33);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(83, 55);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(169, 20);
            this.txtThang.TabIndex = 13;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(83, 88);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(169, 20);
            this.txtNam.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 40F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // MaHopDong
            // 
            this.MaHopDong.DataPropertyName = "MaHopDong";
            this.MaHopDong.HeaderText = "Mã HD";
            this.MaHopDong.Name = "MaHopDong";
            this.MaHopDong.ReadOnly = true;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.FillWeight = 70F;
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            this.Nam.FillWeight = 60F;
            this.Nam.HeaderText = "Năm";
            this.Nam.Name = "Nam";
            this.Nam.ReadOnly = true;
            // 
            // TienPhong
            // 
            this.TienPhong.DataPropertyName = "Tienphong";
            this.TienPhong.FillWeight = 99.8308F;
            this.TienPhong.HeaderText = "Tiền phòng";
            this.TienPhong.Name = "TienPhong";
            this.TienPhong.ReadOnly = true;
            // 
            // Tiennuoc
            // 
            this.Tiennuoc.DataPropertyName = "Tiennuoc";
            this.Tiennuoc.FillWeight = 99.8308F;
            this.Tiennuoc.HeaderText = "Tiền nước";
            this.Tiennuoc.Name = "Tiennuoc";
            this.Tiennuoc.ReadOnly = true;
            // 
            // TienDien
            // 
            this.TienDien.DataPropertyName = "Tiendien";
            this.TienDien.FillWeight = 99.8308F;
            this.TienDien.HeaderText = "Tiền điện";
            this.TienDien.Name = "TienDien";
            this.TienDien.ReadOnly = true;
            // 
            // Phuphi
            // 
            this.Phuphi.DataPropertyName = "Phuphi";
            this.Phuphi.FillWeight = 99.8308F;
            this.Phuphi.HeaderText = "Phụ phí";
            this.Phuphi.Name = "Phuphi";
            this.Phuphi.ReadOnly = true;
            // 
            // Tongtien
            // 
            this.Tongtien.DataPropertyName = "Tongtien";
            this.Tongtien.FillWeight = 99.8308F;
            this.Tongtien.HeaderText = "Tổng tiền";
            this.Tongtien.Name = "Tongtien";
            this.Tongtien.ReadOnly = true;
            // 
            // Dathanhtoan
            // 
            this.Dathanhtoan.DataPropertyName = "DaThanhToan";
            this.Dathanhtoan.FillWeight = 120F;
            this.Dathanhtoan.HeaderText = "Đã Thanh Toán";
            this.Dathanhtoan.Name = "Dathanhtoan";
            this.Dathanhtoan.ReadOnly = true;
            this.Dathanhtoan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Chitiet
            // 
            this.Chitiet.DataPropertyName = "Chitiet";
            this.Chitiet.HeaderText = "Chi tiết";
            this.Chitiet.Name = "Chitiet";
            this.Chitiet.ReadOnly = true;
            this.Chitiet.Visible = false;
            // 
            // btnBaocao
            // 
            this.btnBaocao.Location = new System.Drawing.Point(660, 444);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(159, 33);
            this.btnBaocao.TabIndex = 6;
            this.btnBaocao.Text = "Báo cáo danh sách hóa đơn";
            this.btnBaocao.UseVisualStyleBackColor = true;
            // 
            // FormQLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 492);
            this.Controls.Add(this.btnBaocao);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grid);
            this.Name = "FormQLHoaDon";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.QLHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private DataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhuphi;
        private System.Windows.Forms.TextBox txtTiendien;
        private System.Windows.Forms.TextBox txtTiennuoc;
        private System.Windows.Forms.TextBox txtTienphong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkTT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdDaTT;
        private System.Windows.Forms.RadioButton rdChuaTT;
        private System.Windows.Forms.RadioButton rdTatca;
        private System.Windows.Forms.ComboBox comboMa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiennuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phuphi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dathanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chitiet;
        private System.Windows.Forms.Button btnBaocao;
    }
}