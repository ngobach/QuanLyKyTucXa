﻿using System;
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
