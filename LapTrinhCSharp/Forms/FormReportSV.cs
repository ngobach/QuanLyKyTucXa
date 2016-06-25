using System;
using System.Windows.Forms;

namespace LapTrinhCSharp.Forms
{
    public partial class FormReportSV : Form
    {
        public FormReportSV()
        {
            InitializeComponent();
        }

        private void FormReportSV_Load(object sender, EventArgs e)
        {
            this.SinhVienTableAdapter.Fill(this.DataSet.SinhVien);
            this.report.RefreshReport();
        }
    }
}
