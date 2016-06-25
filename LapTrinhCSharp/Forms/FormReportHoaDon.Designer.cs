using LapTrinhCSharp.MainDatasetTableAdapters;

namespace LapTrinhCSharp.Forms
{
    partial class FormReportHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataSet = new LapTrinhCSharp.MainDataset();
            this.report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonTableAdapter = new LapTrinhCSharp.MainDatasetTableAdapters.HoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report
            // 
            this.report.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.report.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSHoaDon";
            reportDataSource1.Value = this.HoaDonBindingSource;
            this.report.LocalReport.DataSources.Add(reportDataSource1);
            this.report.LocalReport.ReportEmbeddedResource = "LapTrinhCSharp.Forms.ReportHoaDon.rdlc";
            this.report.Location = new System.Drawing.Point(0, 0);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(894, 390);
            this.report.TabIndex = 0;
            this.report.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // HoaDonBindingSource
            // 
            this.HoaDonBindingSource.DataMember = "HoaDon";
            this.HoaDonBindingSource.DataSource = this.DataSet;
            // 
            // HoaDonTableAdapter
            // 
            this.HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 390);
            this.Controls.Add(this.report);
            this.MaximizeBox = false;
            this.Name = "FormReportHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo danh sách hóa đơn";
            this.Load += new System.EventHandler(this.FormReportSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report;
        private MainDataset DataSet;
        private System.Windows.Forms.BindingSource HoaDonBindingSource;
        private HoaDonTableAdapter HoaDonTableAdapter;
    }
}