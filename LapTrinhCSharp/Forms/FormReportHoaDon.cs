using System;
using System.Windows.Forms;

namespace LapTrinhCSharp.Forms
{
    public partial class FormReportHoaDon : Form
    {
        public FormReportHoaDon()
        {
            InitializeComponent();
        }

        private void FormReportSV_Load(object sender, EventArgs e)
        {
            this.HoaDonTableAdapter.Fill(this.DataSet.HoaDon);
            this.report.RefreshReport();
        }
    }
}
