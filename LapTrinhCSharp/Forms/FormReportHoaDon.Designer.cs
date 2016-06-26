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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataset = new LapTrinhCSharp.MainDataset();
            this.mainDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportHoaDonTableAdapter = new LapTrinhCSharp.MainDatasetTableAdapters.ReportHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatasetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // report
            // 
            this.report.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.report.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSHopDong";
            reportDataSource1.Value = null;
            this.report.LocalReport.DataSources.Add(reportDataSource1);
            this.report.LocalReport.ReportEmbeddedResource = "LapTrinhCSharp.Forms.ReportHopDong.rdlc";
            this.report.Location = new System.Drawing.Point(0, 0);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(894, 390);
            this.report.TabIndex = 0;
            this.report.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DSHoaDon";
            reportDataSource2.Value = this.reportHoaDonBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "LapTrinhCSharp.Forms.ReportHoaDon.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(1194, 762);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // reportHoaDonBindingSource
            // 
            this.reportHoaDonBindingSource.DataMember = "ReportHoaDon";
            this.reportHoaDonBindingSource.DataSource = this.mainDataset;
            // 
            // mainDataset
            // 
            this.mainDataset.DataSetName = "MainDataset";
            this.mainDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainDatasetBindingSource
            // 
            this.mainDatasetBindingSource.DataSource = this.mainDataset;
            this.mainDatasetBindingSource.Position = 0;
            // 
            // reportHoaDonTableAdapter
            // 
            this.reportHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 762);
            this.Controls.Add(this.reportViewer);
            this.MaximizeBox = false;
            this.Name = "FormReportHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo danh sách hóa đơn";
            this.Load += new System.EventHandler(this.FormReportSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatasetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource mainDatasetBindingSource;
        private MainDataset mainDataset;
        private System.Windows.Forms.BindingSource reportHoaDonBindingSource;
        private ReportHoaDonTableAdapter reportHoaDonTableAdapter;
    }
}