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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fn;
            Boolean result = User.Check(txtUID.Text, txtPwd.Text,out fn);
            if (result)
            {
                MessageBox.Show("Đăng nhập thành công!\nXin chào " + fn, "Login!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                (new FormMain()).Show();
                Hide();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void check(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
