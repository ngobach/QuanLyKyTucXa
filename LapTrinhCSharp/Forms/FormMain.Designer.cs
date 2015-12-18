namespace LapTrinhCSharp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.btnQLHopDong = new System.Windows.Forms.Button();
            this.btnQLPhong = new System.Windows.Forms.Button();
            this.btnQLHoaDon = new System.Windows.Forms.Button();
            this.btnQuanLyUser = new System.Windows.Forms.Button();
            this.btnQuanLySinhVien = new System.Windows.Forms.Button();
            this.btnTimKiemSV = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(90, 104);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐH Điện Lực HN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // table
            // 
            this.table.ColumnCount = 3;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.Controls.Add(this.btnQLHopDong, 0, 1);
            this.table.Controls.Add(this.btnQLPhong, 0, 1);
            this.table.Controls.Add(this.btnQLHoaDon, 0, 1);
            this.table.Controls.Add(this.btnQuanLyUser, 0, 0);
            this.table.Controls.Add(this.btnQuanLySinhVien, 1, 0);
            this.table.Controls.Add(this.btnTimKiemSV, 2, 0);
            this.table.Location = new System.Drawing.Point(0, 268);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.Size = new System.Drawing.Size(800, 142);
            this.table.TabIndex = 1;
            // 
            // btnQLHopDong
            // 
            this.btnQLHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLHopDong.AutoSize = true;
            this.btnQLHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHopDong.Image = ((System.Drawing.Image)(resources.GetObject("btnQLHopDong.Image")));
            this.btnQLHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHopDong.Location = new System.Drawing.Point(0, 71);
            this.btnQLHopDong.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLHopDong.Name = "btnQLHopDong";
            this.btnQLHopDong.Size = new System.Drawing.Size(266, 71);
            this.btnQLHopDong.TabIndex = 16;
            this.btnQLHopDong.Text = "Quản Lý Hợp Đồng";
            this.btnQLHopDong.UseVisualStyleBackColor = true;
            this.btnQLHopDong.Click += new System.EventHandler(this.btnQLHopDong_Click);
            // 
            // btnQLPhong
            // 
            this.btnQLPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLPhong.AutoSize = true;
            this.btnQLPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnQLPhong.Image")));
            this.btnQLPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPhong.Location = new System.Drawing.Point(266, 71);
            this.btnQLPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLPhong.Name = "btnQLPhong";
            this.btnQLPhong.Size = new System.Drawing.Size(266, 71);
            this.btnQLPhong.TabIndex = 15;
            this.btnQLPhong.Text = "Quản Lý Phòng";
            this.btnQLPhong.UseVisualStyleBackColor = true;
            this.btnQLPhong.Click += new System.EventHandler(this.btnQLPhong_Click);
            // 
            // btnQLHoaDon
            // 
            this.btnQLHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLHoaDon.AutoSize = true;
            this.btnQLHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnQLHoaDon.Image")));
            this.btnQLHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHoaDon.Location = new System.Drawing.Point(532, 71);
            this.btnQLHoaDon.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLHoaDon.Name = "btnQLHoaDon";
            this.btnQLHoaDon.Size = new System.Drawing.Size(268, 71);
            this.btnQLHoaDon.TabIndex = 14;
            this.btnQLHoaDon.Text = "Quản lý hóa đơn";
            this.btnQLHoaDon.UseVisualStyleBackColor = true;
            this.btnQLHoaDon.Click += new System.EventHandler(this.btnQLHoaDon_Click);
            // 
            // btnQuanLyUser
            // 
            this.btnQuanLyUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuanLyUser.AutoSize = true;
            this.btnQuanLyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyUser.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyUser.Image")));
            this.btnQuanLyUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyUser.Location = new System.Drawing.Point(0, 0);
            this.btnQuanLyUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuanLyUser.Name = "btnQuanLyUser";
            this.btnQuanLyUser.Size = new System.Drawing.Size(266, 71);
            this.btnQuanLyUser.TabIndex = 1;
            this.btnQuanLyUser.Text = "Quản Lý User";
            this.btnQuanLyUser.UseVisualStyleBackColor = true;
            this.btnQuanLyUser.Click += new System.EventHandler(this.btnQuanLyUser_Click);
            // 
            // btnQuanLySinhVien
            // 
            this.btnQuanLySinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuanLySinhVien.AutoSize = true;
            this.btnQuanLySinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLySinhVien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuanLySinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLySinhVien.Image")));
            this.btnQuanLySinhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySinhVien.Location = new System.Drawing.Point(266, 0);
            this.btnQuanLySinhVien.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuanLySinhVien.Name = "btnQuanLySinhVien";
            this.btnQuanLySinhVien.Size = new System.Drawing.Size(266, 71);
            this.btnQuanLySinhVien.TabIndex = 2;
            this.btnQuanLySinhVien.Text = "Quản Lý Sinh Viên";
            this.btnQuanLySinhVien.UseVisualStyleBackColor = true;
            this.btnQuanLySinhVien.Click += new System.EventHandler(this.btnQuanLySinhVien_Click);
            // 
            // btnTimKiemSV
            // 
            this.btnTimKiemSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemSV.AutoSize = true;
            this.btnTimKiemSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimKiemSV.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemSV.Image")));
            this.btnTimKiemSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemSV.Location = new System.Drawing.Point(532, 0);
            this.btnTimKiemSV.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimKiemSV.Name = "btnTimKiemSV";
            this.btnTimKiemSV.Size = new System.Drawing.Size(268, 71);
            this.btnTimKiemSV.TabIndex = 3;
            this.btnTimKiemSV.Text = "Tìm kiếm Sinh Viên";
            this.btnTimKiemSV.UseVisualStyleBackColor = true;
            this.btnTimKiemSV.Click += new System.EventHandler(this.btnTimKiemSV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.table);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button btnQuanLyUser;
        private System.Windows.Forms.Button btnQuanLySinhVien;
        private System.Windows.Forms.Button btnTimKiemSV;
        private System.Windows.Forms.Button btnQLHoaDon;
        private System.Windows.Forms.Button btnQLPhong;
        private System.Windows.Forms.Button btnQLHopDong;

    }
}