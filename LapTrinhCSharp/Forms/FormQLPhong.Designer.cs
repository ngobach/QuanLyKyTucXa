namespace LapTrinhCSharp.Forms
{
    partial class FormQLPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLPhong));
            this.gridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToiDa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNha = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVT = new System.Windows.Forms.ComboBox();
            this.btnVTAdd = new System.Windows.Forms.Button();
            this.btVTDelete = new System.Windows.Forms.Button();
            this.lstVT = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFree = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnVTUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToResizeColumns = false;
            this.gridView.AllowUserToResizeRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaNha,
            this.Nha,
            this.Ten,
            this.ToiDa});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.gridView.Location = new System.Drawing.Point(12, 36);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersVisible = false;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(409, 439);
            this.gridView.TabIndex = 999;
            this.gridView.SelectionChanged += new System.EventHandler(this.gridView_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 30F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // MaNha
            // 
            this.MaNha.DataPropertyName = "MaNha";
            this.MaNha.HeaderText = "MaNha";
            this.MaNha.Name = "MaNha";
            this.MaNha.ReadOnly = true;
            this.MaNha.Visible = false;
            // 
            // Nha
            // 
            this.Nha.DataPropertyName = "Nha";
            this.Nha.FillWeight = 70F;
            this.Nha.HeaderText = "Nhà";
            this.Nha.Name = "Nha";
            this.Nha.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên phòng";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // ToiDa
            // 
            this.ToiDa.DataPropertyName = "ToiDa";
            this.ToiDa.HeaderText = "Tối Đa";
            this.ToiDa.Name = "ToiDa";
            this.ToiDa.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(427, 432);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 40);
            this.btnAdd.TabIndex = 100;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(524, 432);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 40);
            this.btnUpdate.TabIndex = 101;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Maroon;
            this.btnXoa.Location = new System.Drawing.Point(621, 432);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 40);
            this.btnXoa.TabIndex = 102;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số người";
            // 
            // txtToiDa
            // 
            this.txtToiDa.Location = new System.Drawing.Point(71, 49);
            this.txtToiDa.Name = "txtToiDa";
            this.txtToiDa.Size = new System.Drawing.Size(47, 20);
            this.txtToiDa.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbNha);
            this.groupBox1.Controls.Add(this.txtToiDa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(427, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhà";
            // 
            // cbNha
            // 
            this.cbNha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNha.FormattingEnabled = true;
            this.cbNha.Location = new System.Drawing.Point(157, 49);
            this.cbNha.Name = "cbNha";
            this.cbNha.Size = new System.Drawing.Size(115, 21);
            this.cbNha.TabIndex = 1001;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên phòng";
            // 
            // cbVT
            // 
            this.cbVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVT.FormattingEnabled = true;
            this.cbVT.Location = new System.Drawing.Point(49, 303);
            this.cbVT.Name = "cbVT";
            this.cbVT.Size = new System.Drawing.Size(104, 21);
            this.cbVT.TabIndex = 0;
            // 
            // btnVTAdd
            // 
            this.btnVTAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnVTAdd.Image")));
            this.btnVTAdd.Location = new System.Drawing.Point(162, 303);
            this.btnVTAdd.Name = "btnVTAdd";
            this.btnVTAdd.Size = new System.Drawing.Size(33, 23);
            this.btnVTAdd.TabIndex = 1;
            this.btnVTAdd.UseVisualStyleBackColor = true;
            this.btnVTAdd.Click += new System.EventHandler(this.btnVTAdd_Click);
            // 
            // btVTDelete
            // 
            this.btVTDelete.Image = ((System.Drawing.Image)(resources.GetObject("btVTDelete.Image")));
            this.btVTDelete.Location = new System.Drawing.Point(240, 303);
            this.btVTDelete.Name = "btVTDelete";
            this.btVTDelete.Size = new System.Drawing.Size(33, 23);
            this.btVTDelete.TabIndex = 1;
            this.btVTDelete.UseVisualStyleBackColor = true;
            this.btVTDelete.Click += new System.EventHandler(this.btVTDelete_Click);
            // 
            // lstVT
            // 
            this.lstVT.FormattingEnabled = true;
            this.lstVT.Location = new System.Drawing.Point(6, 20);
            this.lstVT.Name = "lstVT";
            this.lstVT.Size = new System.Drawing.Size(267, 160);
            this.lstVT.TabIndex = 2;
            this.lstVT.SelectedIndexChanged += new System.EventHandler(this.lstVT_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstVT);
            this.groupBox2.Controls.Add(this.btVTDelete);
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.txtCount);
            this.groupBox2.Controls.Add(this.btnVTUpdate);
            this.groupBox2.Controls.Add(this.btnVTAdd);
            this.groupBox2.Controls.Add(this.cbVT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(425, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 332);
            this.groupBox2.TabIndex = 1000;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các vật tư";
            // 
            // chkFree
            // 
            this.chkFree.AutoSize = true;
            this.chkFree.Location = new System.Drawing.Point(13, 13);
            this.chkFree.Name = "chkFree";
            this.chkFree.Size = new System.Drawing.Size(124, 17);
            this.chkFree.TabIndex = 1001;
            this.chkFree.Text = "Chỉ hiện phòng trống";
            this.chkFree.UseVisualStyleBackColor = true;
            this.chkFree.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vật tư";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số lượng";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(63, 186);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(210, 20);
            this.txtCount.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ghi chú";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(11, 231);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(262, 66);
            this.txtNote.TabIndex = 2;
            // 
            // btnVTUpdate
            // 
            this.btnVTUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnVTUpdate.Image")));
            this.btnVTUpdate.Location = new System.Drawing.Point(201, 303);
            this.btnVTUpdate.Name = "btnVTUpdate";
            this.btnVTUpdate.Size = new System.Drawing.Size(33, 23);
            this.btnVTUpdate.TabIndex = 1;
            this.btnVTUpdate.UseVisualStyleBackColor = true;
            this.btnVTUpdate.Click += new System.EventHandler(this.btnVTUpdate_Click);
            // 
            // FormQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 487);
            this.Controls.Add(this.chkFree);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormQLPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToiDa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbVT;
        private System.Windows.Forms.Button btnVTAdd;
        private System.Windows.Forms.Button btVTDelete;
        private System.Windows.Forms.ListBox lstVT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbNha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToiDa;
        private System.Windows.Forms.CheckBox chkFree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnVTUpdate;
    }
}

