using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LapTrinhCSharp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuanLySinhVien_Click(object sender, EventArgs e)
        {
            ShowForm(new FormQLSinhVien());
        }

        private void btnQuanLyUser_Click(object sender, EventArgs e)
        {
            ShowForm(new FormUser());
        }

        private void ShowForm(Form f)
        {
            f.Show();
            f.FormClosed += (s, e) => Show();
            Hide();
        }

        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            ShowForm(new FormTimKiemSV());
        }
    }
}
