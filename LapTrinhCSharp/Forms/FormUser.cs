using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using LapTrinhCSharp.Models;

namespace LapTrinhCSharp
{
    public partial class FormUser : Form
    {

        public FormUser()
        {
            InitializeComponent();
        }
        
        private void LoadGrid()
        {
            grid.DataSource = User.All();
            LoadForm();
        }

        private void LoadForm()
        {
            if (grid.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = grid.SelectedRows[0];
            txtFullName.Text = (string)row.Cells["HoTen"].Value;
            txtQueQuan.Text = (string)row.Cells["QueQuan"].Value;
            datePicker.Value = (DateTime)row.Cells["NgaySinh"].Value;
            txtUsername.Text = (string)row.Cells["Username"].Value;
            txtPwd.Text = txtRePwd.Text = "";
        }

        private bool ValidateInput(bool requirePwd)
        {
            if (txtUsername.Text.Length < 4)
            {
                MessageBox.Show("Username tối thiểu 4 kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtFullName.Text.Length == 0)
            {
                MessageBox.Show("FullName không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((requirePwd || (!requirePwd && txtPwd.Text.Length > 0)) && txtPwd.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu tối thiểu 6 kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPwd.Text != txtRePwd.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private User ReadUser()
        {
            User user = new User();
            user.Username = txtUsername.Text;
            user.HoTen = txtFullName.Text;
            user.MatKhau = txtPwd.Text;
            user.NgaySinh = datePicker.Value;
            user.QueQuan = txtQueQuan.Text;
            return user;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            LoadForm();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput(false) && grid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = grid.SelectedRows[0];
                try
                {
                    User user = ReadUser();
                    user.Update(row.Cells["Username"].Value.ToString());
                    MessageBox.Show("Cập nhật thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                }
                catch (SqlException exc)
                {
                    if (exc.Number == DB.ERR_CONFLICK)
                    {
                        MessageBox.Show("Username hoặc ID đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi" + exc.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput(true))
            {
                try
                {
                    User user = ReadUser();
                    user.Create();
                    MessageBox.Show("Thêm mới user thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                }
                catch (SqlException exc)
                {
                    if (exc.Number == DB.ERR_CONFLICK)
                    {
                        MessageBox.Show("Username hoặc ID đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi" + exc.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                User user = ReadUser();
                try
                {
                    user.Delete();
                    MessageBox.Show("Xóa user thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                }
                catch (SqlException exc)
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
