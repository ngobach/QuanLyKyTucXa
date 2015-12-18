using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhCSharp
{
    public partial class FormReportHoaDon : Form
    {
        public FormReportHoaDon()
        {
            InitializeComponent();
        }

        private void FormReportSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.HoaDon' table. You can move, or remove it, as needed.
            this.HoaDonTableAdapter.Fill(this.DataSet.HoaDon);
            this.report.RefreshReport();
        }
    }
}
