using System;
using System.Windows.Forms;

namespace LapTrinhCSharp.Forms
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
            ShowForm(new FormQLVatTu());
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            ShowForm(new FormQLPhong());
        }

        private void btnQLHopDong_Click(object sender, EventArgs e)
        {
            ShowForm(new FormQLHopDong());
        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            ShowForm(new FormQLHoaDon());
        }
    }
}
