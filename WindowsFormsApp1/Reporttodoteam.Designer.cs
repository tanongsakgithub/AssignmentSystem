
namespace WindowsFormsApp1
{
    partial class Reporttodoteam
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetAssignDB = new WindowsFormsApp1.DataSetAssignDB();
            this.tbltaskteamReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbltaskteamReportTableAdapter = new WindowsFormsApp1.DataSetAssignDBTableAdapters.tbltaskteamReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAssignDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltaskteamReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbltaskteamReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Reporttodoteam.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetAssignDB
            // 
            this.DataSetAssignDB.DataSetName = "DataSetAssignDB";
            this.DataSetAssignDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbltaskteamReportBindingSource
            // 
            this.tbltaskteamReportBindingSource.DataMember = "tbltaskteamReport";
            this.tbltaskteamReportBindingSource.DataSource = this.DataSetAssignDB;
            // 
            // tbltaskteamReportTableAdapter
            // 
            this.tbltaskteamReportTableAdapter.ClearBeforeFill = true;
            // 
            // Reporttodoteam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporttodoteam";
            this.Text = "Reporttodoteam";
            this.Load += new System.EventHandler(this.Reporttodoteam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAssignDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltaskteamReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbltaskteamReportBindingSource;
        private DataSetAssignDB DataSetAssignDB;
        private DataSetAssignDBTableAdapters.tbltaskteamReportTableAdapter tbltaskteamReportTableAdapter;
    }
}