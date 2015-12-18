namespace LapTrinhCSharp
{
    partial class FormReportSV
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
            this.report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet = new LapTrinhCSharp.DataSet();
            this.SinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SinhVienTableAdapter = new LapTrinhCSharp.DataSetTableAdapters.SinhVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // report
            // 
            this.report.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.SinhVienBindingSource;
            this.report.LocalReport.DataSources.Add(reportDataSource1);
            this.report.LocalReport.ReportEmbeddedResource = "LapTrinhCSharp.Forms.ReportSV.rdlc";
            this.report.Location = new System.Drawing.Point(0, -2);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(894, 395);
            this.report.TabIndex = 0;
            this.report.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SinhVienBindingSource
            // 
            this.SinhVienBindingSource.DataMember = "SinhVien";
            this.SinhVienBindingSource.DataSource = this.DataSet;
            // 
            // SinhVienTableAdapter
            // 
            this.SinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 390);
            this.Controls.Add(this.report);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormReportSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo danh sách sinh viên";
            this.Load += new System.EventHandler(this.FormReportSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report;
        private System.Windows.Forms.BindingSource SinhVienBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.SinhVienTableAdapter SinhVienTableAdapter;
    }
}