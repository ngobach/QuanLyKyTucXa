using System;
using System.Windows.Forms;

namespace LapTrinhCSharp.Forms
{
    public partial class FormReportHopDong : Form
    {
        public FormReportHopDong()
        {
            InitializeComponent();
        }

        private void FormReportSV_Load(object sender, EventArgs e)
        {
            this.HopDongTableAdapter.Fill(this.DataSet.HopDong);
            this.report.RefreshReport();
        }
    }
}
