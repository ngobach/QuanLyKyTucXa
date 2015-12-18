using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // Nhận sự kiện button Login click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fn;
            // Gọi hàm kiểm tra username và mật khẩu mà người dùng nhập vào
            Boolean result = User.Check(txtUID.Text, txtPwd.Text,out fn);
            if (result)
            {
                // Nếu thông tin đăng nhập chính xác
                MessageBox.Show("Đăng nhập thành công!\nXin chào " + fn, "Login!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Hiện form menu
                (new FormMain()).Show();
                // Ẩn form đăng nhập đi
                Hide();
            }
            else
                // thông tin không chính xác
                // Yêu cầu người dùng nhập lại
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Nhận sự kiện người dùng nhấn nút Enter
        // Gọi hàm đăng nhập
        private void check(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra mã phím có phải Enter = mã 13
            if (e.KeyChar == 13)
            {
                // Gọi hàm đăng nhập
                btnLogin_Click(null, null);
            }
        }
    }
}
