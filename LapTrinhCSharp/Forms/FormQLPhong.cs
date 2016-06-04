﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LapTrinhCSharp
{
    public partial class FormQLPhong : Form
    {
        public FormQLPhong()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            gridView.DataSource = Phong.All();
        }

        private Phong ReadForm()
        {
            Phong p = new Phong();
            p.TenPhong = txtName.Text;
            if (gridView.SelectedRows.Count > 0)
            {
                p.ID = (int)gridView.SelectedRows[0].Cells["ID"].Value;
            }
            return p;
        }

        private void LoadFormData()
        {
            if (gridView.SelectedRows.Count == 0)
                return;
            txtName.Text = gridView.SelectedRows[0].Cells["TenPhong"].Value.ToString() ;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ReadForm().Create();
                MessageBox.Show("Thêm mới thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (SqlException exc)
            {
                if (exc.Number == DB.ERR_CONFLICK)
                {
                    MessageBox.Show("Mã phòng Này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ReadForm().Update();
                MessageBox.Show("Cập nhật thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (SqlException exc)
            {
                if (exc.Number == DB.ERR_CONFLICK)
                {
                    MessageBox.Show("Mã phòng Này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ReadForm().Delete();
                MessageBox.Show("Xóa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            LoadFormData();
        }

    }
}
