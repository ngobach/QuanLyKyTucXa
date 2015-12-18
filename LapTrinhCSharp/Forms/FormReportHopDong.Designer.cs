namespace LapTrinhCSharp
{
    partial class FormReportHopDong
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
            this.DataSet = new LapTrinhCSharp.DataSet();
            this.report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HopDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HopDongTableAdapter = new LapTrinhCSharp.DataSetTableAdapters.HopDongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HopDongBindingSource)).BeginInit();
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
            reportDataSource1.Name = "DSHopDong";
            reportDataSource1.Value = this.HopDongBindingSource;
            this.report.LocalReport.DataSources.Add(reportDataSource1);
            this.report.LocalReport.ReportEmbeddedResource = "LapTrinhCSharp.Forms.ReportHopDong.rdlc";
            this.report.Location = new System.Drawing.Point(0, 0);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(894, 390);
            this.report.TabIndex = 0;
            this.report.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // HopDongBindingSource
            // 
            this.HopDongBindingSource.DataMember = "HopDong";
            this.HopDongBindingSource.DataSource = this.DataSet;
            // 
            // HopDongTableAdapter
            // 
            this.HopDongTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 390);
            this.Controls.Add(this.report);
            this.MaximizeBox = false;
            this.Name = "FormReportHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo danh sách hợp đồng";
            this.Load += new System.EventHandler(this.FormReportSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HopDongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report;
        private DataSet DataSet;
        private System.Windows.Forms.BindingSource HopDongBindingSource;
        private DataSetTableAdapters.HopDongTableAdapter HopDongTableAdapter;
    }
}