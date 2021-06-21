
namespace WindowsFormsApp1
{
    partial class ReportTeam
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
            this.tblteamReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetAssignDB = new WindowsFormsApp1.DataSetAssignDB();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblteamReportTableAdapter = new WindowsFormsApp1.DataSetAssignDBTableAdapters.tblteamReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblteamReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAssignDB)).BeginInit();
            this.SuspendLayout();
            // 
            // tblteamReportBindingSource
            // 
            this.tblteamReportBindingSource.DataMember = "tblteamReport";
            this.tblteamReportBindingSource.DataSource = this.DataSetAssignDB;
            // 
            // DataSetAssignDB
            // 
            this.DataSetAssignDB.DataSetName = "DataSetAssignDB";
            this.DataSetAssignDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblteamReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ReportTeam.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1081, 489);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblteamReportTableAdapter
            // 
            this.tblteamReportTableAdapter.ClearBeforeFill = true;
            // 
            // ReportTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 513);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportTeam";
            this.Load += new System.EventHandler(this.ReportTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblteamReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAssignDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblteamReportBindingSource;
        private DataSetAssignDB DataSetAssignDB;
        private DataSetAssignDBTableAdapters.tblteamReportTableAdapter tblteamReportTableAdapter;
    }
}