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
            // TODO: This line of code loads data into the 'mainDataset.ReportHoaDon' table. You can move, or remove it, as needed.
            this.reportHoaDonTableAdapter.Fill(this.mainDataset.ReportHoaDon);

            this.reportViewer.RefreshReport();
        }
    }
}
